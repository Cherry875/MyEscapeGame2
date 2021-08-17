using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PanelChanger : MonoBehaviour
{
    public GameObject rightArrow;
    public GameObject leftArrow;
    public GameObject backArrow;
    public Panel startPanel;

    private Panel currentPanel;


    // Start is called before the first frame update
    //スタート地点を決める
    private void Start()
    {
        showPanel(startPanel);
    }

    private void showPanel(Panel nextPanel)
    {
        currentPanel = nextPanel;
        Debug.Log(nextPanel+"に移動");
        this.transform.localPosition = new Vector2(0,0) - nextPanel.position();
        leftArrow.SetActive(nextPanel!=nextPanel.leftPanel);
        rightArrow.SetActive(nextPanel!=nextPanel.rightPanel);
        backArrow.SetActive(nextPanel!=nextPanel.backPanel);
        //thisはこのスクリプトを貼り付けてあるPanelParentのこと
    }

    public void OnRightArrow()
    {
        showPanel(currentPanel.rightPanel);
    }
    public void OnLeftArrow()
    {
        showPanel(currentPanel.leftPanel);
    }
    public void OnBackArrow()
    {
        showPanel(currentPanel.backPanel);
    }

    // public void OnDesk()
    // {
    //     showPanel(currentPanel.backPanel);
    // }
    // public void OnSafe()
    // {
    //     showPanel(Panel2.KeyPanel);
    // }
    // public void OnKeystand()
    // {
    //     showPanel(Panel2.LargeKye);
    // }
}
