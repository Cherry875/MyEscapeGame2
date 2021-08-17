using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Tank : MonoBehaviour
{
    public GameObject TankforUse;
    public GameObject Tank_used;
    public GameObject Beaker;
    
    // Start is called before the first frame update
    void Start()
    {
        TankforUse.SetActive(true);
        Tank_used.SetActive(false);
        Beaker.SetActive(true);
    }

    public void OnTank()
    {
        if(!MakeReagent.complete)
        {
            TankforUse.SetActive(false);
            Tank_used.SetActive(true);
            Debug.Log("total="+MakeReagent.total);
            if(MakeReagent.total != 0)
            {
                Sounds.SND.PlayPourSounds();
            }
            MakeReagent.MRT.ResetStatus();
            Beaker.SetActive(false);
            //何秒後に元に戻すか
            Invoke("TankReturen", 1.0f);
        }
    }

    //元に戻す操作
    void TankReturen()
    {
        Tank_used.SetActive(false);
        TankforUse.SetActive(true);
        Beaker.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
