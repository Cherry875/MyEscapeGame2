using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Panel : MonoBehaviour
{
    Vector2 place;
    public Panel rightPanel;
    public Panel leftPanel;
    public Panel backPanel;
    void Start()
    {
       place = this.transform.localPosition;
    }
    public Vector2 position(){
        return place;
    }

}
