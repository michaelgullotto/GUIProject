using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryUI : MonoBehaviour
{
    public RectTransform InventoryPanel;
    public RectTransform scrollViewConent;
    InventoryUIItem itemContainer { get; set;}
    bool menuIsActive { get; set; }
    Item currentSelectedItem { get; set;}
    void Start()
    {
        itemContainer = Resources.Load<InventoryUIItem>("UI/Item_Container");
        UIEventHandeler.OnItemAddedToInventtroy += ItemAdded;
        InventoryPanel.gameObject.SetActive(false);
    }

    private void Update()
    {
        if(Inputmanger.inputmanger.KeyDown("Inventory"))
        {
            menuIsActive = !menuIsActive;
            InventoryPanel.gameObject.SetActive(menuIsActive);
        }
    }

    public void ItemAdded(Item item)
    {
        InventoryUIItem emptyItem = Instantiate(itemContainer);
        emptyItem.SetItem(item);
        emptyItem.transform.SetParent(scrollViewConent);
    }
 
}
