using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ingameheath : MonoBehaviour
{
   
    void Update()
    {
        GetComponent<TMPro.TextMeshProUGUI>().text = Mystats.currenthealth.ToString() + "/" + Mystats.maxhealth.ToString();
    }
}
