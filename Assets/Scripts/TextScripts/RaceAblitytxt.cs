using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RaceAblitytxt : MonoBehaviour
{
   
    void Update()
    {
        GetComponent<TMPro.TextMeshProUGUI>().text = Mystats.raceAblity;
    }
}
