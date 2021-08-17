using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Melt : MonoBehaviour
{
    public GameObject KeyStand;
    public GameObject KeyStandsmall;
    public GameObject MeltStand;
    public GameObject MeltStandsmall;
    public GameObject Trukey;
    public GameObject Trukeysmall;
    public Image PouringBeaker;
    public Sprite reagent;
    public Sprite beaker;

    private Color color1,color2,color3;

    // Start is called before the first frame update
    //最初はビーカーは見えなくしておく
    void Start()
    {
        Color c = PouringBeaker.color;
        PouringBeaker.color=new Color(c.r,c.b,c.g,0);
        MeltStand.SetActive(false);
        MeltStandsmall.SetActive(false);
        Trukey.SetActive(false);
        Trukeysmall.SetActive(false);
        KeyStand.SetActive(true);
        KeyStandsmall.SetActive(true);
    }

    public void OnStand()
    {
        if(UseItem.SelectedItem == Item.ItemType.Reagent)
        {
            DoMelt();
            ItemBox.IBX.DeleteItem(Item.ItemType.Reagent);
        }
    }

    private void DoMelt()
    {
        PouringBeaker.sprite = reagent;
        Color c = PouringBeaker.color;
        PouringBeaker.color=new Color(c.r,c.b,c.g,1);
        Invoke("ShowMleted",1.0f);
        Invoke("HideBeaker",2.0f);
    }

    private void ShowMleted()
    {
        PouringBeaker.sprite = beaker;
        KeyStand.SetActive(false);
        KeyStandsmall.SetActive(false);
        MeltStand.SetActive(true);
        MeltStandsmall.SetActive(true);
        Trukey.SetActive(true);
        Trukeysmall.SetActive(true);
    }

    private void HideBeaker()
    {
        Color c = PouringBeaker.color;
        PouringBeaker.color=new Color(c.r,c.b,c.g,0);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
