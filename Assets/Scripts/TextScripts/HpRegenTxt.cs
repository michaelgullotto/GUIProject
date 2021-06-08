using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HpRegenTxt : MonoBehaviour
{
   
    void Update()
    {
        GetComponent<TMPro.TextMeshProUGUI>().text = "Health Regen:" + Mystats.healthregen.ToString();
    }
}
