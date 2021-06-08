using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHeading : MonoBehaviour
{
 

  
    void Update()
    {
      GetComponent<TMPro.TextMeshProUGUI>().text = "level: " + Mystats.level.ToString() + " " + Mystats.race + " "+ Mystats.playerclass;
    }
}
