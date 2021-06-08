using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MaxhealthTxt : MonoBehaviour
{
  
    void Update()
    {
        GetComponent<TMPro.TextMeshProUGUI>().text = "Max Health:" + Mystats.maxhealth.ToString();
    }
}
