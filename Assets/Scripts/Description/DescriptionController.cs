using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DescriptionController : MonoBehaviour
{
    public GameObject X_mark;
    private Item currentItem;
    public static DescriptionController descon;

    public static Item dummy;

    public static Item def(){
        return(dummy);
    }
    //インスタンス化
    private void Awake()
    {
        descon = this;
        dummy = Instantiate(Resources.Load<GameObject>("dummy")).GetComponent(typeof(Item)) as Item;
        X_mark.SetActive(false);
    }

    // Start is called before the first frame update
    void Start()
    {
    }


    // Update is called once per frame
    void Update()
    {
        
    }

    public void ShowDetail(Item item)
    {
        //詳細を書いたパネルを見せる
        item.descriptionPanel.ShowDetail();
        X_mark.SetActive(true);
        currentItem = item;
    }

    public void OnXmark()
    {
        HideDetail(currentItem);
    }

    public void HideDetail(Item item)
    {
        item.descriptionPanel.HideDetail();
        X_mark.SetActive(false);
    }

}
