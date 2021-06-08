using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StrengthTxt : MonoBehaviour
{
   

    // Update is called once per frame
    void Update()
    {
       GetComponent<TMPro.TextMeshProUGUI>().text = "Strength:" + Mystats.strength.ToString();
    }
}
