using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SafeBoxController : MonoBehaviour
{
    public GameObject ClosedSafeBox;
    public GameObject OpenSafebox;
    public GameObject SmallBin;
    
    public static SafeBoxController SBC;

    void Awake()
    {
        SBC = this;
    }
    
    private void Start()
    {
        SetSafeBox(false);
    }

    public void SetSafeBox(bool open)
    {
        ClosedSafeBox.SetActive(!open);
        OpenSafebox.SetActive(open);
        SmallBin.SetActive(open);
    }
}
