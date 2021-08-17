using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SterlReagent : MonoBehaviour
{
    public GameObject Beaker;
    public GameObject Sterling1;
    public GameObject Sterling2;
    public GameObject Ster1;
    public GameObject Ster2;
    public GameObject Reagent;
    public Image Beaker_img;

    private Color color1,color2,color3;

    // Start is called before the first frame update
    void Start()
    {
        Beaker.SetActive(true);
        Sterling1.SetActive(false);
        Sterling2.SetActive(false);
        Reagent.SetActive(false);
        Ster1.SetActive(false);
        Ster2.SetActive(false);
    }

    public void OnBeaker()
    {
        //もしオレンジだったら、かきまぜて完成させる
        if(UseItem.SelectedItem == Item.ItemType.Sterler && MakeReagent.complete)
        {
            //ビーカーを透明にする
            Color c = Beaker_img.color;
            Beaker_img.color=new Color(c.r,c.b,c.g,0);
            Sterling1.SetActive(true);
            ShowAnime();
        }
        //もし完成してなかったら、ただかき混ぜる
        else if(UseItem.SelectedItem == Item.ItemType.Sterler && !MakeReagent.complete)
        {
            ShowFakeAnime();
        }
    }

    private void ShowAnime()
    {
        Invoke("ShowSterling2", 0.5f);
        Invoke("ShowReagent", 1.0f);
    }

    private void ShowFakeAnime()
    {
        Ster1.SetActive(true);
        Invoke("ShowSter2",0.5f);
        Invoke("HideSter2",1.0f);
    }

    private void ShowSterling2()
    {
        Sterling1.SetActive(false);
        Sterling2.SetActive(true);
    }

    private void ShowReagent()
    {
        Sterling2.SetActive(false);
        Reagent.SetActive(true);
        Beaker.SetActive(false);
    }

    private void ShowSter2()
    {
        Ster1.SetActive(false);
        Ster2.SetActive(true);
    }

    private void HideSter2()
    {
        Ster2.SetActive(false);
    }
}
