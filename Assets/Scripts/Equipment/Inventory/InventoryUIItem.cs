using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InventoryUIItem : MonoBehaviour
{
    public Item item;
    public Text itemtext;
    public Image itemIcon;
    // sets up all the values for the items
    public void SetItem(Item item)
    {
        this.item = item;
        SetUpItemvalues();
    }
    // sets itrms icon and text // issue here help me please
    void SetUpItemvalues()
    {
        itemtext.text = item.itemName;
        itemIcon.sprite = Resources.Load<Sprite>("UI/Icons/Items" + item.ObjectSlug); 
    }
    // makes the items selectable in inventory
    public void onsSelectItemButton()
    {
        InventoryController.Instance.setItemDetails(item, GetComponent<Button>());
    }
}
