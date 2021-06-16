using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryUI : MonoBehaviour
{
    public KeyBinds keybinds;
    public RectTransform InventoryPanel;
    public RectTransform scrollViewConent;
    InventoryUIItem itemContainer { get; set;}
    bool menuIsActive { get; set; }
    Item currentSelectedItem { get; set;}
    
    void Start()
    {
        // genrates what we need to instaiate things into inventory UI
        itemContainer = Resources.Load<InventoryUIItem>("UI/Item_Container");
        UIEventHandeler.OnItemAddedToInventtroy += ItemAdded;
        InventoryPanel.gameObject.SetActive(false);
    }

    private void Update()
    {
        // opens and closes inventoy from keydown
        if(keybinds.GetKeyDown("Inventory"))
        {
            menuIsActive = !menuIsActive;
            InventoryPanel.gameObject.SetActive(menuIsActive);
        }
    }
    // instaiates UI into inventory when item is picked up
    public void ItemAdded(Item item)
    {
        InventoryUIItem emptyItem = Instantiate(itemContainer);
        emptyItem.SetItem(item);
        emptyItem.transform.SetParent(scrollViewConent);
    }
 
}
