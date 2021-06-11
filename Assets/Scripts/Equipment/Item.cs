using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item 
{
    public string ObjectSlug { get; set; }
    public string itemName { get; set; }
    public string description { get; set; }
    public string itemType { get; set; }
    public string actionName { get; set; }
    public bool itemModifier { get; set; }


    [Newtonsoft.Json.JsonConstructor]
    public Item(string _ObjectSlug, string _itemName, string _description , string _itemType , string _actionName , bool _itemModifier )
    {
        this.ObjectSlug = _ObjectSlug;
        this.itemName = _itemName;
        this.description = _description;
        this.itemType = _itemType;
        this.actionName = _actionName;
        this.itemModifier = _itemModifier;
        
    }

}
