using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetReagent : MonoBehaviour
{
    public GameObject Stand;
    public GameObject without;

    public void ReturnItems()
    {
        ItemBox.IBX.DeleteItemFromType(Item.ItemType.Pipet);
        ItemBox.IBX.DeleteItemFromType(Item.ItemType.Sterler);
        Stand.SetActive(true);
        without.SetActive(false);
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
