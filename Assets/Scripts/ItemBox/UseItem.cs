using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UseItem : MonoBehaviour
{
    public enum BoxSlot
    {
        box1,
        box2,
        box3,
        box4,
        box5,
    }
    public BoxSlot box;

    //インスタンス化
    public static UseItem UIM;
    private void Awake()
    {
        UIM = this;
    }

    //記録のために使う変数の指定
    public static int ClickTimes;
    public static Item.ItemType SelectedItem;

    private void Start()
    {
        //FrameControler.FMC.SelectorReset();
        ClickTimes = 0;
        SelectedItem = Item.ItemType.non;
    }


    public void OnBox()
    {
        if(box == BoxSlot.box1 && ItemBox.occupation >=1)
        {
            ProcessSort(box,0);
        }
        else if(box == BoxSlot.box2 && ItemBox.occupation >=2)
        {
            ProcessSort(box,1);
        }
        else if(box == BoxSlot.box3 && ItemBox.occupation >=3)
        {
            ProcessSort(box,2);
        }
        else if(box == BoxSlot.box4 && ItemBox.occupation >=4)
        {
            ProcessSort(box,3);
        }
        else if(box == BoxSlot.box5 && ItemBox.occupation >=5)
        {
            ProcessSort(box,4);
        }
        else
        {
            Debug.Log("No item here");
        }
    }

    private void ProcessSort(BoxSlot box,int num)
    {
        if(SelectedItem == ItemBox.BoxContent[num])
        {
            //同じBoxを連続クリックしているときの処理
            if(ClickTimes==1)
            {
                //同じBoxを連続2回クリックされたら
                Descriptions.DSC.ShowDetail(ItemBox.BoxContent[num]);
                ClickTimes++;
                Debug.Log(SelectedItem+" clicked twice!");
            }
            else if(ClickTimes==2)
            {
                //3回連続クリックされたらリセット
                FrameControler.FMC.SelectorReset();
                Descriptions.DSC.HideDetail();
                ClickTimes = 0;
                SelectedItem = Item.ItemType.non;
                Debug.Log(SelectedItem+" clicked 3 times!");
            }
            else if(ClickTimes==0)
            {
                //リセット後はelseと同じ処理
                DoSelect(num);
                Debug.Log(SelectedItem+" clicked again");                                
            }
        }
        else
        {
            //初めてクリックされた時に起こること
            ClickTimes = 0;
            DoSelect(num);
            Debug.Log(SelectedItem+" clicked for the first time!");
        }
    }

    private void DoSelect(int num)
    {
        FrameControler.FMC.SelectorReset();
        FrameControler.FMC.SelectorSet(num);
        AudioItem.ADI.PlaySelectSound();
        SelectedItem = ItemBox.BoxContent[num];
        ClickTimes++;
    }
}
