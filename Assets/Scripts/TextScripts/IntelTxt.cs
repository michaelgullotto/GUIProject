using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IntelTxt : MonoBehaviour
{
  
    void Update()
    {
        GetComponent<TMPro.TextMeshProUGUI>().text = "Intelligence:" + Mystats.intelligence.ToString();
    }
}
