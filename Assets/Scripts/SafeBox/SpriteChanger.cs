using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SpriteChanger : MonoBehaviour
{
    public Image Keyimage;
    public Sprite zero;
    public Sprite one;
    public Sprite two;
    public Sprite three;
    public Sprite four;
    public Sprite five;
    public Sprite six;
    public Sprite seven;
    public Sprite eight;
    public Sprite nine;

    public static int FirstNum;
    public static int SecondNum;
    public static int ThirdNum;
    public static int ForthNum;


    // Start is called before the first frame update

    //金庫のパス
    int[] answer = new int[] {1, 9, 5, 4};

    private void Awake()
    {
        FirstNum = 0;
        SecondNum = 0;
        ThirdNum = 0;
        ForthNum = 0;
    }

    public void OnKey(int number)
    {
        if(number == 1)
        {
            OnFirstKye();
        }
        else if(number == 2)
        {
            OnSecondKye();
        }
        else if(number == 3)
        {
            OnThirdKye();
        }
        else if(number == 4)
        {
            OnForthKye();
        }
        CheckAnswer();
    }

    private void OnFirstKye()
    {
        Sprite[] SpriteNames = {zero,one,two,three,four,five,six,seven,eight,nine};
        FirstNum = (FirstNum+1)%10;
        Keyimage.sprite = SpriteNames[FirstNum];
    }
    
    private void OnSecondKye()
    {
        Sprite[] SpriteNames = {zero,one,two,three,four,five,six,seven,eight,nine};
        SecondNum = (SecondNum+1)%10;
        Keyimage.sprite = SpriteNames[SecondNum];
    }
    
    private void OnThirdKye()
    {
        Sprite[] SpriteNames = {zero,one,two,three,four,five,six,seven,eight,nine};
        ThirdNum = (ThirdNum+1)%10;
        Keyimage.sprite = SpriteNames[ThirdNum];
    }

    private void OnForthKye()
    {
        Sprite[] SpriteNames = {zero,one,two,three,four,five,six,seven,eight,nine};
        ForthNum = (ForthNum+1)%10;
        Keyimage.sprite = SpriteNames[ForthNum];
    }

    private void CheckAnswer()
    {
        //正解だったら、金庫を開けて、金庫が開く音を鳴らす
        if(answer[0]==FirstNum && answer[1]==SecondNum && answer[2]==ThirdNum&& answer[3]==ForthNum)
        {
            SafeBoxController.SBC.SetSafeBox(true);
            AudioSafeBox.ASB.PlayOpenSound();
            Debug.Log(answer[0]+","+FirstNum+" | "+answer[1]+","+SecondNum+" | "+answer[2]+","+ThirdNum+" | "+","+answer[3]+","+ForthNum+"opened!");
        }
        //まだ正解していない時はキーのクリック音を鳴らす
        else
        {
            SafeBoxController.SBC.SetSafeBox(false);
            AudioSafeBox.ASB.PlayClickSound();
            Debug.Log(answer[0]+","+FirstNum+" | "+answer[1]+","+SecondNum+" | "+answer[2]+","+ThirdNum+" | "+","+answer[3]+","+ForthNum);
        }
    }

}


