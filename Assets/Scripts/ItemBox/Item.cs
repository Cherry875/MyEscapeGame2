using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item : MonoBehaviour
{
    //アイテムの設定
    public enum ItemType
    {
        Key,
        Jar,
        Paper,
        book,
        Pipet,
        Sterler,
        Reagent,
        TrueKye,
        non,
    }

    public ItemType itemtype;

    public Descriptions descriptionPanel;

    // public Desciprtions(ItemType type){
    //     // if(itemtype==type){return descriptionPanel;}
    // }

    //クリックした時にアイテムボックスに格納されて消え、音が鳴る

   void Start()
    {
        
    }

    public void GetItem()
    {
        Debug.Log(itemtype+"を取得、occupation="+ItemBox.occupation);
        AudioItem.ADI.PlayGetSound();
        ItemBox.IBX.SetItem(this);
        gameObject.SetActive(false);
    }
}
