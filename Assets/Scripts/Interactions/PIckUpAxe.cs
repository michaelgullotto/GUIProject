using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PIckUpAxe : Interactable
{
    // tells game what item is being picked up
    public override void Interact()
    {
        //GameObject.Destroy(this);
        InventoryController.Instance.giveItem("Axe");

    }

}
