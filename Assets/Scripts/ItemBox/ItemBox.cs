using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class ItemBox : MonoBehaviour
{
    public Sprite paper_sprite;
    public Sprite key_sprite;
    public Sprite jar_sprite;
    public Sprite book_sprite;
    public Sprite new_key_sprite;
    public Sprite pipet_sprite;
    public Sprite sterler_sprite;
    public Sprite reagent_sprite;
    public Sprite truekey_sprite;
    public Image Box1;
    public Image Box2;
    public Image Box3;
    public Image Box4;
    public Image Box5;
    public Image Box6;


    //occupation:取得する前、アイテムボックスにアイテムがいくつあるか
    public static int occupation;
    public static Item.ItemType[] BoxContent;

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
        occupation = 0;
        BoxContent = new Item.ItemType[6];
        for(int i=0;i<=5;i++)
        {
            BoxContent[i] = Item.ItemType.non;
        }
        DoColorOff(Box1);
        DoColorOff(Box2);
        DoColorOff(Box3);
        DoColorOff(Box4);
        DoColorOff(Box5);
    }

    //アイテムを取得したときの動き(大枠)
    public void SetItem(Item.ItemType type)
    {
        if(occupation == 0)
        {
            BoxSetter(Box1,type);
        }
        else if(occupation == 1)
        {
            BoxSetter(Box2,type);
        }
        else if(occupation == 2)
        {
            BoxSetter(Box3,type);
        }
        else if(occupation == 3)
        {
            BoxSetter(Box4,type);
        }
        else if(occupation == 4)
        {
            BoxSetter(Box5,type);
        }
        else if(occupation == 5)
        {
            BoxSetter(Box6,type);
        }
        occupation ++;
    }

    //アイテムを取得したときの動き(詳細)
    private void BoxSetter(Image box, Item.ItemType type)
    {
        BoxContent[occupation] = type;
        Debug.Log(occupation+"に"+BoxContent[occupation]+"が記録されました");
        if(type == Item.ItemType.Key)
        {
            box.sprite = key_sprite;
            DoColorOn(box);
        }
        else if(type == Item.ItemType.Jar)
        {
            box.sprite = jar_sprite;
            DoColorOn(box);
        }
        else if(type == Item.ItemType.Paper)
        {
            box.sprite = paper_sprite;
            DoColorOn(box);
        }
        else if(type == Item.ItemType.book)
        {
            box.sprite = book_sprite;
            DoColorOn(box);
        }
        else if(type == Item.ItemType.Pipet)
        {
            box.sprite = pipet_sprite;
            DoColorOn(box);
        }
        else if(type == Item.ItemType.Sterler)
        {
            box.sprite = sterler_sprite;
            DoColorOn(box);
        }
        else if(type == Item.ItemType.Reagent)
        {
            box.sprite = reagent_sprite;
            DoColorOn(box);
        }
        else if(type == Item.ItemType.TrueKye)
        {
            box.sprite = truekey_sprite;
            DoColorOn(box);
        }
        else if(type == Item.ItemType.non)
        {
            DoColorOff(box);
        }
    }

    private int used;
    //アイテムを使い終わったときの動き(大枠)
    public void DeleteItem(Item.ItemType type)
    {
        for (int i=0; i<=5; i++)
        {
            if(BoxContent[i] == type)
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
        if(i == 0)
        {
            DoColorOff(Box1);
        }
        else if(i == 1)
        {
            DoColorOff(Box2);
        }
        else if(i == 2)
        {
            DoColorOff(Box3);
        }
        else if(i == 3)
        {
            DoColorOff(Box4);
        }
        else if(i == 4)
        {
            DoColorOff(Box5);
        }
        FrameControler.FMC.SelectorReset();
        UseItem.ClickTimes = 0;
        UseItem.SelectedItem = Item.ItemType.non;
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
           BoxContent[i] = BoxContent[i+1];
        }
        BoxContent[5] = Item.ItemType.non;
    }

    private void SpriteRearrange()
    {
        BoxSetter(Box1,BoxContent[0]);
        Debug.Log("Box1に"+BoxContent[0]+"を");
        BoxSetter(Box2,BoxContent[1]);
        Debug.Log("Box2に"+BoxContent[1]+"を");
        BoxSetter(Box3,BoxContent[2]);
        Debug.Log("Box3に"+BoxContent[2]+"を");
        BoxSetter(Box4,BoxContent[3]);
        Debug.Log("Box4に"+BoxContent[3]+"を");
        BoxSetter(Box5,BoxContent[4]);
        Debug.Log("Box5に"+BoxContent[4]+"を");
    }
}
