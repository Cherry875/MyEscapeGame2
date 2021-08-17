using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Descriptions : MonoBehaviour
{
    public GameObject OldKey_dsc;
    public GameObject Paper_dsc;
    public GameObject Jar_dsc;
    public GameObject book_dsc;
    public GameObject Pipet_dsc;
    public GameObject Sterler_dsc;
    public GameObject NewKye_dsc;
    public GameObject Beaker_dsc;
    public GameObject X_mark;

    //インスタンス化
    public static Descriptions DSC;
    private void Awake()
    {
        DSC = this;
    }

    // Start is called before the first frame update
    void Start()
    {
        HideDetail();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ShowDetail(Item.ItemType item)
    {
        //詳細を書いたパネルを見せる
        if(item == Item.ItemType.Key)
        {
            OldKey_dsc.SetActive(true);
        }
        else if(item == Item.ItemType.Jar)
        {
            Jar_dsc.SetActive(true);
        }
        else if(item == Item.ItemType.Paper)
        {
            Paper_dsc.SetActive(true);
        }
        else if(item == Item.ItemType.book)
        {
            book_dsc.SetActive(true);
        }
        else if(item == Item.ItemType.Pipet)
        {
            Pipet_dsc.SetActive(true);
        }
        else if(item == Item.ItemType.Sterler)
        {
            Sterler_dsc.SetActive(true);
        }
        else if(item == Item.ItemType.TrueKye)
        {
            NewKye_dsc.SetActive(true);
        }
        else if(item == Item.ItemType.Reagent)
        {
            Beaker_dsc.SetActive(true);
        }
        X_mark.SetActive(true);
    }

    public void OnXmark()
    {
        HideDetail();
    }

    public void HideDetail()
    {
        OldKey_dsc.SetActive(false);
        Paper_dsc.SetActive(false);
        Jar_dsc.SetActive(false);
        book_dsc.SetActive(false);
        Pipet_dsc.SetActive(false);
        Sterler_dsc.SetActive(false);
        NewKye_dsc.SetActive(false);
        Beaker_dsc.SetActive(false);
        X_mark.SetActive(false);
    }

}
