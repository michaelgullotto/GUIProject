using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ingameStamina : MonoBehaviour
{
 
    // Update is called once per frame
    void Update()
    {
        GetComponent<TMPro.TextMeshProUGUI>().text = Mystats.currentstamina.ToString() + "/" + Mystats.stamina.ToString(); 
    }
}
