using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UseItem : MonoBehaviour
{

    public int boxId;

    //インスタンス化
    public static UseItem UIM;
    private void Awake()
    {
        UIM = this;
    }

    //記録のために使う変数の指定
    public static int ClickTimes;
    public static Item SelectedItem;

    private void Start()
    {
        //FrameControler.FMC.SelectorReset();
        ClickTimes = 0;
        SelectedItem = DescriptionController.def();
    }


    public void OnBox()
    {
        if(ItemBox.occupation > boxId){
            ProcessSort(boxId);
        }else{
            Debug.Log("No item here");
        }
    }

    private void ProcessSort(int num)
    {
        if(SelectedItem == ItemBox.BoxContents[num])
        {
            //同じBoxを連続クリックしているときの処理
            if(ClickTimes==1)
            {
                //同じBoxを連続2回クリックされたら
                DescriptionController.descon.ShowDetail(SelectedItem);
                Debug.Log(SelectedItem+" clicked twice!");
            }
            else if(ClickTimes==2)
            {
                //3回連続クリックされたらリセット
                FrameControler.FMC.SelectorReset();
                DescriptionController.descon.HideDetail(SelectedItem);
                SelectedItem = DescriptionController.def();
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
            ClickTimes = (ClickTimes + 1) % 3;
    }

    private void DoSelect(int num)
    {
        FrameControler.FMC.SelectorReset();
        FrameControler.FMC.SelectorSet(num);
        AudioItem.ADI.PlaySelectSound();
        SelectedItem = ItemBox.BoxContents[num];
    }
}
