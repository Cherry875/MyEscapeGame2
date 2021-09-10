using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Descriptions : MonoBehaviour
{
    //インスタンス化
    public static Descriptions DSC;
    public GameObject dscGameObject;
    private void Awake()
    {
        DSC = this;
    }

    // Start is called before the first frame update
    void Start()
    {
        HideDetail();
    }

    public void ShowDetail()
    {
        //詳細を書いたパネルを見せる
        dscGameObject.SetActive(true);
    }

    public void HideDetail()
    {
        dscGameObject.SetActive(false);
    }

}
