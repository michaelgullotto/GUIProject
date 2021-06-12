using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InventoryUIItem : MonoBehaviour
{
    public Item item;

    public void SetItem(Item item)
    {
        this.item = item;
        SetUpItemvalues();
    }

    void SetUpItemvalues()
    {
        this.transform.Find("Item_Name").GetComponent<Text>().text = item.itemName;
    }

    public void onsSelectItemButton()
    {
        InventoryController.Instance.setItemDetails(item, GetComponent<Button>());
    }
}
