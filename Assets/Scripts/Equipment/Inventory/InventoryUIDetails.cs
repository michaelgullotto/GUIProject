using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class InventoryUIDetails : MonoBehaviour
{
    Item item;
    Button SelectedItemButton, itemInteractButton, dropbuton;
    Text itemNameText, itemDescriptionText, itemInteractButtonText;
    // grabs components we need for this script to work so we dont have to do in inspector 
    private void Start()
    {
        itemNameText = transform.Find("Item_Name").GetComponent<Text>();
        itemDescriptionText = transform.Find("Item_Description").GetComponent<Text>();
        itemInteractButton = transform.Find("Interact_Button").GetComponent<Button>();
        dropbuton = transform.Find("Drop").GetComponent<Button>();
        itemInteractButtonText = itemInteractButton.transform.Find("Text").GetComponent<Text>();
    }
    // works out whatn item is selected in inventory
    public void SetItem (Item item,Button button)
    {
        itemInteractButton.onClick.RemoveAllListeners();
        this.item = item;
        SelectedItemButton = button;
        itemNameText.text = item.itemName;
        itemDescriptionText.text = item.description;
        itemInteractButtonText.text = item.actionName;
        itemInteractButton.onClick.AddListener(OnItemInteract);
       
        dropbuton.onClick.RemoveAllListeners();
        dropbuton.onClick.AddListener(dropItem);
    }
    // lets you equip or consume item based on it item type
    public void OnItemInteract()
    {
        if (item.itemType == Item.ItemTypes.Consumable)
        {
            InventoryController.Instance.ConsumeItem(item);
            Destroy(SelectedItemButton.gameObject);
        }
        else if(item.itemType == Item.ItemTypes.Weapon)
        {
            InventoryController.Instance.EquipItem(item);
            Destroy(SelectedItemButton.gameObject);
        }
    }

    public void dropItem()
    {
        InventoryController.Instance.Dropitem(item);
        Destroy(SelectedItemButton.gameObject);

    }
}
