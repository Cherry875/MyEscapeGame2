using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class ItemBox : MonoBehaviour
{
    public Image[] Boxes;


    //occupation:取得する前、アイテムボックスにアイテムがいくつあるか
    public static int occupation;
    public static Item[] BoxContents;
    Item dummy;

    //Imageの色をColorに入れる
    private Color color1,color2,color3;

    //インスタンス化
    public static ItemBox IBX;
    private void Awake()
    {
        IBX = this;
    }
    
    
    // Start is called before the first frame update
    void Start()
    {
        dummy =DescriptionController.def();
        occupation = 0;
        BoxContents = new Item[6];
        for(int i=0;i<=5;i++)
        {
            BoxContents[i] = dummy;
            DoColorOff(Boxes[i]);
        }
    }

    //アイテムを取得したときの動き(大枠)
    public void SetItem(Item item)
    {
        BoxSetter(Boxes[occupation],item);
        occupation ++;
    }

    //アイテムを取得したときの動き(詳細)
    private void BoxSetter(Image box, Item item)
    {
        BoxContents[occupation] = item;
        Item.ItemType type = item.itemtype;
        Debug.Log(occupation+"に"+BoxContents[occupation]+"が記録されました");
        box.sprite = item.sprite;
        DoColorOn(box);
    }

    private int used;
    //アイテムを使い終わったときの動き(大枠)
    public void DeleteItem(Item item)
    {
        Item.ItemType type = item.itemtype;
        for (int i=0; i<=5; i++)
        {
            if(BoxContents[i] == item)
            {
                ColorSelectorOff(i);
                Rearrange(i);
                SpriteRearrange();
            }
        }
        occupation --;
    }
    public void DeleteItemFromType(Item.ItemType type)
    {
        for (int i=0; i<=5; i++)
        {
            if(BoxContents[i].itemtype == type)
            {
                ColorSelectorOff(i);
                Rearrange(i);
                SpriteRearrange();
            }
        }
        occupation --;
    }

    //アイテムを使い終わったときの動き(詳細1)
    private void ColorSelectorOff(int i)
    {
        DoColorOff(Boxes[i]);
        FrameControler.FMC.SelectorReset();
        UseItem.ClickTimes = 0;
        UseItem.SelectedItem = dummy;
    }

    //アイテムを使い終わったときの動きパーツ:イメージの色を消す
    private void DoColorOff(Image box)
    {
        Color c = box.color;
        box.color=new Color(c.r,c.b,c.g,0);
    }

    //アイテムを表示するときの動きパーツ:イメージの色をつける
    private void DoColorOn(Image box)
    {
        Color c = box.color;
        box.color=new Color(c.r,c.b,c.g,1); 
    }

    //used番目のアイテムが消えたときに、左詰になるようBoxContentの中身を更新
    private void Rearrange(int used)
    {
        for(int i=used;i<=5-1;i++)
        {
           BoxContents[i] = BoxContents[i+1];
        }
        BoxContents[5] = dummy;
    }

    private void SpriteRearrange()
    {
        for (int i = 0; i < 5; i++)
        {
            BoxSetter(Boxes[i],BoxContents[i]);
            Debug.Log("Box"+(i+1)+"に"+BoxContents[i]+"を");
        }
    }
}
