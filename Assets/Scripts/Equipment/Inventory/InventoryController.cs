using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InventoryController : MonoBehaviour
{
    public static InventoryController Instance { get; set;}
    public WeaponController weaponcontroller;
    //public Item Axe;
    public List<Item> playerItems = new List<Item>();
    public InventoryUIDetails inventoryDetailsPanel;

    // makes sure there is only 1 inventory controller
    public void Awake()
    {
        inventoryDetailsPanel = GetComponent<InventoryUIDetails>();

        if (Instance != null && Instance != this)
        {
            Destroy(gameObject);
        }
        Instance = this;
       

    }
    //sets up details display for item selected
    public void setItemDetails(Item item, Button button)
    {
        
        inventoryDetailsPanel.SetItem(item, button);
    }
    // works out what item is being added to inventory 
    public void giveItem(string itemslug)

    {
        Item item = Itemdatabase.instance.GetItem(itemslug);
        playerItems.Add(item);
        UIEventHandeler.ItemAddedToInventory(item);
    }
    // equips the item
     public void EquipItem(Item  itemToEquip)
    {
        weaponcontroller.EquipSlot1(itemToEquip);

    }
    // future proofing for consumables will consume item
    public void ConsumeItem(Item itemtoconsume)
    {
        //consumecontroller.ConsumeItem(itemtoconsume);
    }

}
