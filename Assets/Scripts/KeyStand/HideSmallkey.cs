using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HideSmallkey : MonoBehaviour
{
    public GameObject SmallKye;
    public GameObject TrueKye;

    public void IfGetTrueKye()
    {
        SmallKye.SetActive(false);
        TrueKye.SetActive(false);
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
