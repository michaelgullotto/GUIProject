using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class inGameDisplay : MonoBehaviour
{
    public Slider healthdisplay;
    public Slider manadisplay;
    public Slider staminadisplay;

    public GameObject firball;
    public GameObject cyclone;
    public GameObject orksmash;
    public GameObject whimper;

    
    void Update()
    {
        //updates displays for health mana and stamina that are displayed in sliders
        healthdisplay.value = Mystats.currenthealth;
        manadisplay.value = Mystats.currentMana;
        staminadisplay.value = Mystats.currentstamina;
        healthdisplay.maxValue = Mystats.maxhealth;
        manadisplay.maxValue = Mystats.maxMana;
        staminadisplay.maxValue = Mystats.stamina;

        // displays icines for class and race ablitys
        if (Mystats.raceAblity == "whimper")
        {
            whimper.SetActive(true);
            orksmash.SetActive(false);
        }
        else if (Mystats.raceAblity == "Ork Smash")
        {
            whimper.SetActive(false);
            orksmash.SetActive(true);
        }


        if (Mystats.classAblity == "cyclone")
        {
            cyclone.SetActive(true);
            firball.SetActive(false);
        }
        else if (Mystats.classAblity == "Fire ball")
        {
            cyclone.SetActive(false);
            firball.SetActive(true);
        }


    }
}
