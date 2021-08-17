using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MakeReagent : MonoBehaviour
{
    public Image Beaker;
    public Sprite empty;
    public Sprite once;
    public Sprite twice;
    public Sprite third;
    public Sprite forth;
    public Sprite orange;

    public static int total;
    public static int large;
    public static int small;
    public static bool complete;

    //インスタンス化
    public static MakeReagent MRT;
    private void Awake()
    {
        MRT = this;
    }


    // Start is called before the first frame update
    void Start()
    {
        complete = false;
        total = 0;
        small = 0;
        large = 0;
    }

    public void OnSmallJar()
    {
        if(UseItem.SelectedItem == Item.ItemType.Pipet)
        {
            DoSmallJar();
        }
    }

    public void OnLargeJar()
    {
        if(UseItem.SelectedItem == Item.ItemType.Pipet)
        {
            DoLargeJar();
        }
    }

    public void ResetStatus()
    {
        total = 0;
        small = 0;
        large = 0;
        Beaker.sprite = empty;
    }

    private void DoSmallJar()
    {
        if(total == 0)
        {
            Beaker.sprite = once;
        }
        else if(total == 1)
        {
            Beaker.sprite = twice;
        }
        else if(total == 2)
        {
            if(small == 0 && large == 2)
            {
                Beaker.sprite = orange;
                complete = true;
            }
            else
            {
                Beaker.sprite = third;
            }
        }
        else if(total == 3)
        {
            Beaker.sprite = forth;
            complete = false;
        }
        else if(total >= 4)
        {
            //エラー音を鳴らす
            complete = false;
        } 
        total ++;
        small ++;
    }

    private void DoLargeJar()
    {
        if(total == 0)
        {
            Beaker.sprite = once;
        }
        else if(total == 1)
        {
            Beaker.sprite = twice;
        }
        else if(total == 2)
        {
            if(small == 1 && large == 1)
            {
                Beaker.sprite = orange;
                complete = true;
            }
            else
            {
                Beaker.sprite = third;
            }
        }
        else if(total == 3)
        {
            Beaker.sprite = forth;
            complete = false;
        }
        else if(total >= 4)
        {
            //エラー音を鳴らす
            complete = false;
        } 
        large++;
        total++;
    }


    // Update is called once per frame
    void Update()
    {
        
    }
}
