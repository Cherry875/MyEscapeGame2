using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FrameControler : MonoBehaviour
{
    public GameObject frame1;
    public GameObject frame2;
    public GameObject frame3;
    public GameObject frame4;
    public GameObject frame5;
    public GameObject frame6;

    //インスタンス化
    public static FrameControler FMC;
    private void Awake()
    {
        FMC = this;
    }

    // Start is called before the first frame update
    void Start()
    {
        SelectorReset();
    }

    public void SelectorReset()
    {
        frame1.SetActive(false);
        frame2.SetActive(false);
        frame3.SetActive(false);
        frame4.SetActive(false);
        frame5.SetActive(false);
        frame6.SetActive(false);
    }

    public void SelectorSet(int num)
    {
        if(num == 0)
        {
            frame1.SetActive(true);
        }
        else if(num ==1)
        {
            frame2.SetActive(true);
        }
        else if(num ==2)
        {
            frame3.SetActive(true);
        }
        else if(num ==3)
        {
            frame4.SetActive(true);
        }
        else if(num ==4)
        {
            frame5.SetActive(true);
        }
    }


    // Update is called once per frame
    void Update()
    {
   
    }
}
