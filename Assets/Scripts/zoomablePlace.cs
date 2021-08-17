using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class zoomablePlace : MonoBehaviour
{
    public PanelChanger panelChanger;
    public Panel zoomedPanel;

    public void onClick()
    {
        panelChanger.showPanel(zoomedPanel);
    }
}
