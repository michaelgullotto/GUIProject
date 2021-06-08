using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MpRegenTxt : MonoBehaviour
{
  
    void Update()
    {
        GetComponent<TMPro.TextMeshProUGUI>().text = "Mana Regen:" + Mystats.manaRegen.ToString();
    }
}
