using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Newtonsoft.Json;

public class Item 
{
    public enum ItemTypes {Weapon, Consumable, Quest }
    public string ObjectSlug { get; set; }
    public string itemName { get; set; }
    public string description { get; set; }
    [JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public ItemTypes itemType { get; set; }
    public string actionName { get; set; }
    public bool itemModifier { get; set; }


    [Newtonsoft.Json.JsonConstructor]
    public Item(string _ObjectSlug, string _itemName, string _description , ItemTypes _itemType , string _actionName , bool _itemModifier )
    {
        this.ObjectSlug = _ObjectSlug;
        this.itemName = _itemName;
        this.description = _description;
        this.itemType = _itemType;
        this.actionName = _actionName;
        this.itemModifier = _itemModifier;
        
    }

}
