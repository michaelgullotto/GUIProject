using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class constTxt : MonoBehaviour
{
  
    void Update()
    {
        GetComponent<TMPro.TextMeshProUGUI>().text = "Constitution:" + Mystats.constitution.ToString();
    }
}
