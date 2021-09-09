using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FrameControler : MonoBehaviour
{
    public GameObject[] frames;

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
        foreach (GameObject frame in frames)
        {
            frame.SetActive(false);
        }
    }

    public void SelectorSet(int num)
    {
        frames[num].SetActive(true);
    }


    // Update is called once per frame
    void Update()
    {
   
    }
}
