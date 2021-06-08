using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class inGameDisplay : MonoBehaviour
{
    public Slider healthdisplay;
    public Slider manadisplay;
    public Slider staminadisplay;

    // Update is called once per frame
    void Update()
    {
        healthdisplay.value = Mystats.currenthealth;
        manadisplay.value = Mystats.currentMana;
        staminadisplay.value = Mystats.currentstamina;
        healthdisplay.maxValue = Mystats.maxhealth;
        manadisplay.maxValue = Mystats.maxMana;
        staminadisplay.maxValue = Mystats.stamina;
    }
}
