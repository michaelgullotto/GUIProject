using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PIckUpAxe : Interactable
{
    
    public override void Interact()
    {
        //player = transform.Find("Player").GetComponent<GameObject>();
        Destroy(InteractbleObject);
        InventoryController.Instance.giveItem("Axe");

    }

}
