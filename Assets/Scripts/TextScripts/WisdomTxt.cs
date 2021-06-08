using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WisdomTxt : MonoBehaviour
{

    void Update()
    {
        GetComponent<TMPro.TextMeshProUGUI>().text = "Wisdom:" + Mystats.wisdom.ToString(); 
    }
}
