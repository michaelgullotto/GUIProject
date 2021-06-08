using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ingameMana : MonoBehaviour
{
   

    // Update is called once per frame
    void Update()
    {
        GetComponent<TMPro.TextMeshProUGUI>().text = Mystats.currentMana.ToString() + "/" + Mystats.maxMana.ToString();
    }
}
