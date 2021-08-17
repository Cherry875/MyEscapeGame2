using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StandControler : MonoBehaviour
{
    public GameObject Stand;
    public GameObject without_pipet;
    public GameObject without;

    // Start is called before the first frame update
    void Start()
    {
        without_pipet.SetActive(false);
        without.SetActive(false);
    }


    public void OnStand()
    {
        Stand.SetActive(false);
        without_pipet.SetActive(true);
    }

    public void OnWithoutPipet()
    {
        without.SetActive(true);
        without_pipet.SetActive(false);
    }


    // Update is called once per frame
    void Update()
    {
        
    }
}
