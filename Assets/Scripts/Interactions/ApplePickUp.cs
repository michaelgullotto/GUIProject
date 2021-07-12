using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ApplePickUp : Interactable
{
    // tells game what item is being picked up
    public override void Interact()
    {
        
        Destroy(InteractbleObject);
        InventoryController.Instance.giveItem("Apple");
        
    }
}