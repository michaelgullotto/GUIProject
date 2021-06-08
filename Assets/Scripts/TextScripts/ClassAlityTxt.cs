using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClassAlityTxt : MonoBehaviour
{
   
    void Update()
    {
        GetComponent<TMPro.TextMeshProUGUI>().text = Mystats.classAblity;
    }
}
