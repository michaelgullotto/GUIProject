using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharismaTxt : MonoBehaviour
{
   
    void Update()
    {
        GetComponent<TMPro.TextMeshProUGUI>().text = "Charisma:" + Mystats.charisma.ToString();
    }
}
