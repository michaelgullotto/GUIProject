using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MaxMPTxt : MonoBehaviour
{
   
    void Update()
    {
        GetComponent<TMPro.TextMeshProUGUI>().text = "Max Mana:" + Mystats.maxMana.ToString();
    }
}
