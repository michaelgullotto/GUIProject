using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIEventHandeler : MonoBehaviour
{
    public delegate void ItemEventHandler(Item item);
    public static event ItemEventHandler OnItemAddedToInventtroy;
   

    public static void ItemAddedToInventory(Item item)
    {
        OnItemAddedToInventtroy(item);
    }

}