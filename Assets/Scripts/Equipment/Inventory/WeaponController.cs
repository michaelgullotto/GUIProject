using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponController : MonoBehaviour
{

    public GameObject equipslot1;
    public GameObject EquipedItem1 { get; set; }

    public void EquipSlot1(Item itemToEquip)
    {
        
        
        if (EquipedItem1 != null)
        {
            Destroy(equipslot1.transform.GetChild(0).gameObject);
        }

        EquipedItem1 = (GameObject)Instantiate(Resources.Load<GameObject>(itemToEquip.ObjectSlug), equipslot1.transform.position, equipslot1.transform.rotation);
        EquipedItem1.transform.SetParent(equipslot1.transform);
    }



}
