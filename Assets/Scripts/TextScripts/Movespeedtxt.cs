using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movespeedtxt : MonoBehaviour
{
   
    void Update()
    {
        GetComponent<TMPro.TextMeshProUGUI>().text = "Move Speed:" + Mystats.Movespeed.ToString();
    }
}
