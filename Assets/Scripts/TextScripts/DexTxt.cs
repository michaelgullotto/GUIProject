using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DexTxt : MonoBehaviour
{
  
    void Update()
    {
        GetComponent<TMPro.TextMeshProUGUI>().text = "Dexterity:" + Mystats.Dextrerity.ToString();
    }
}
