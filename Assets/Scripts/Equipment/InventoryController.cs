using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryController : MonoBehaviour
{
    public static InventoryController Instance { get; set;}
    public WeaponController weaponcontroller;
    public Item Axe;

    public void Start()
    {
        if (Instance != null && Instance != this)
        {
            Destroy(gameObject);
        }
        Instance = this;


       // Axe = new Item ("Axe");
    }

    //private void Update()
    //{
    //    if (Input.GetKeyDown(KeyCode.Space))
    //    {
    //        weaponcontroller.EquipSlot1(Axe);
    //    }
    //}

}
