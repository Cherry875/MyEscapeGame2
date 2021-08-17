using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PanelChanger : MonoBehaviour
{
    // Start is called before the first frame update

    public GameObject rightArrow;
    public GameObject leftArrow;
    public GameObject backArrow;

    // Update is called once per frame

    enum Panel
    {
        Main,
        Desk,
        Safe,
        Shelf,
        KeyPanel,
        Door,
        LargeKye,
    }

    private Panel currentPanel;

    //スタート地点を決める
    private void Start()
    {
        showPanel(Panel.Door);
    }

    //int配列に各パネルを見るためのポシションを格納
    // private int[] MainPosi = {0,0};
    private Vector2 DeskPosi = new Vector2(-1000,0);
    private Vector2 SafePosi = new Vector2(0,1500);
    private Vector2 ShelfPosi = new Vector2(-1000,1500);
    private Vector2 KeyPanelPosi = new Vector2(-1000,3000);
    private Vector2 DoorPosi = new Vector2(0,3000);
    private Vector2 KyePosi = new Vector2(-3000,0);
    private Vector2 MainPosi = new Vector2(0,0);
    //bool配列に各パネルで表示するべき矢印の情報を格納{left,back,right}
    private bool[] MainArrow = {true,true,true};
    private bool[] DeskArrow = {false,true,false};
    private bool[] SafeArrow = {true,false,false};
    private bool[] ShelfArrow = {false,false,true};
    private bool[] KeyPanelArrow = {false,true,false};
    private bool[] DoorArrow = {false,true,false};
    private bool[] KyeArrow = {false,true,false};

    private void showPanel(Panel nextpanel)
    {
        if(nextpanel == Panel.LargeKye)
        {
            this.transform.localPosition = KyePosi;
            currentPanel = Panel.LargeKye;
            leftArrow.SetActive(KyeArrow[0]);
            backArrow.SetActive(KyeArrow[1]);
            rightArrow.SetActive(KyeArrow[2]);
        }        
        else if(nextpanel == Panel.Door)
        {
            this.transform.localPosition = DoorPosi;
            currentPanel = Panel.Door;
            leftArrow.SetActive(DoorArrow[0]);
            backArrow.SetActive(DoorArrow[1]);
            rightArrow.SetActive(DoorArrow[2]);
        }
        else if(nextpanel == Panel.Main)
        {
            this.transform.localPosition = MainPosi;
            currentPanel = Panel.Main;
            leftArrow.SetActive(MainArrow[0]);
            backArrow.SetActive(MainArrow[1]);
            rightArrow.SetActive(MainArrow[2]);
            //thisはこのスクリプトを貼り付けてあるPanelParentのこと
        }
        else if(nextpanel == Panel.Safe)
        {
            this.transform.localPosition = SafePosi;
            currentPanel = Panel.Safe;
            leftArrow.SetActive(SafeArrow[0]);
            backArrow.SetActive(SafeArrow[1]);
            rightArrow.SetActive(SafeArrow[2]);
            //thisはこのスクリプトを貼り付けてあるPanelParentのこと
        }
        else if(nextpanel == Panel.Desk)
        {
            this.transform.localPosition = DeskPosi;
            currentPanel = Panel.Desk;
            leftArrow.SetActive(DeskArrow[0]);
            backArrow.SetActive(DeskArrow[1]);
            rightArrow.SetActive(DeskArrow[2]);
            //thisはこのスクリプトを貼り付けてあるPanelParentのこと
        }
        else if(nextpanel == Panel.Shelf)
        {
            this.transform.localPosition = ShelfPosi;
            currentPanel = Panel.Shelf;
            leftArrow.SetActive(ShelfArrow[0]);
            backArrow.SetActive(ShelfArrow[1]);
            rightArrow.SetActive(ShelfArrow[2]);
            //thisはこのスクリプトを貼り付けてあるPanelParentのこと
        }
        else if(nextpanel == Panel.KeyPanel)
        {
            this.transform.localPosition = KeyPanelPosi;
            currentPanel = Panel.KeyPanel;
            leftArrow.SetActive(KeyPanelArrow[0]);
            backArrow.SetActive(KeyPanelArrow[1]);
            rightArrow.SetActive(KeyPanelArrow[2]);
            //thisはこのスクリプトを貼り付けてあるPanelParentのこと
        }
    }

    public void OnRightArrow()
    {
        if(currentPanel == Panel.Main)
        {
            showPanel(Panel.Safe);
        }
        else if(currentPanel == Panel.Shelf)
        {
            showPanel(Panel.Main);
        }
    }
    public void OnLeftArrow()
    {
        if(currentPanel == Panel.Main)
        {
            showPanel(Panel.Shelf);
        }
        else if(currentPanel == Panel.Safe)
        {
            showPanel(Panel.Main);
        }
    }
    public void OnBackArrow()
    {
        if(currentPanel == Panel.Desk)
        {
            showPanel(Panel.Main);
        }
        else if(currentPanel == Panel.KeyPanel)
        {
            showPanel(Panel.Safe);
        }
        else if(currentPanel == Panel.Main)
        {
            showPanel(Panel.Door);
        }
        else if(currentPanel == Panel.Door)
        {
            showPanel(Panel.Main);
        }
        else if(currentPanel == Panel.LargeKye)
        {
            showPanel(Panel.Door);
        }
    }

    public void OnDesk()
    {
        showPanel(Panel.Desk);
    }
    public void OnSafe()
    {
        showPanel(Panel.KeyPanel);
    }
    public void OnKeystand()
    {
        showPanel(Panel.LargeKye);
    }
}
