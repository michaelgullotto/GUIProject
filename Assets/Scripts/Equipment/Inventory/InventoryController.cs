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

    public void Awake()
    {
        inventoryDetailsPanel = GetComponent<InventoryUIDetails>();

        if (Instance != null && Instance != this)
        {
            Destroy(gameObject);
        }
        Instance = this;
       

    }
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            giveItem("Axe");
            giveItem("Apple");
        }
    }
    public void setItemDetails(Item item, Button button)
    {
        
        inventoryDetailsPanel.SetItem(item, button);
    }
    public void giveItem(string itemslug)

    {
        Item item = Itemdatabase.instance.GetItem(itemslug);
        playerItems.Add(item);
        UIEventHandeler.ItemAddedToInventory(item);
    }
     public void EquipItem(Item  itemToEquip)
    {
        weaponcontroller.EquipSlot1(itemToEquip);

    }
    public void ConsumeItem(Item itemtoconsume)
    {
        //consumecontroller.ConsumeItem(itemtoconsume);
    }

}
