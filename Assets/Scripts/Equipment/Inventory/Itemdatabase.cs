using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Newtonsoft.Json;

public class Itemdatabase : MonoBehaviour
{
    public static Itemdatabase instance { get; set; }
    private List<Item> Items { get; set; }
   // makes sure this is only ittem database
    void Awake ()
    {

        if (instance != null && instance != this)
        {
            Destroy(gameObject);
        }
        else
        {
            instance = this;
        }
        
        BuildDatabase();

    }
    // deserlizes JSON file and builds the datsbase from JSON
    private void BuildDatabase()
    {
        Items = JsonConvert.DeserializeObject<List<Item>>(Resources.Load<TextAsset>("JSON/Items").ToString());

        //Debug.Log(Items[0].description);
    }
    //  returns which item it is based on name
    public Item GetItem(string itemSlug)
    {
        foreach (Item item in Items)
        {
            if (item.ObjectSlug == itemSlug)
            {
                return item;
            }

        }
        Debug.Log("couldnt find" + itemSlug);
        return null;

    }
}
