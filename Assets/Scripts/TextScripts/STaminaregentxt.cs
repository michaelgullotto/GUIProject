using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class STaminaregentxt : MonoBehaviour
{
  
    void Update()
    {
        GetComponent<TMPro.TextMeshProUGUI>().text = "Stamina Regen:" + Mystats.staminaregen.ToString();
    }
}
