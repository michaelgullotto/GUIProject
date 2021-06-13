using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManger : MonoBehaviour
{
    public int time = 1;
    public bool manafull = false;
    public bool healthfull = false;
    public bool staminafull = false;
    [SerializeField] Mystats mystats;
    // Start is called before the first frame update
    
  
    void Start()
    {
        // loads chater on start
        mystats.loadGame();
      
        // keeps track of where in scence index we are
        levelloader.Index = 3;
       

    }

   
    void Update()
    {
        // starts regen coroutines for health and mana
        if (Mystats.currenthealth < Mystats.maxhealth  )
        {
           if (healthfull == false)
            {
                healthfull = true;
                StartCoroutine(healthregen());

            }
        }

        if (Mystats.currentMana < Mystats.maxMana)
        {
            if (manafull == false)
            {
                manafull = true;
                StartCoroutine(manaregen());

            }
        }
    

    }
    // coroutines fr health and mana regen
    private IEnumerator healthregen()
    {
    
        while (Mystats.currenthealth < Mystats.maxhealth)
        {
            Mystats.currenthealth = Mystats.currenthealth + Mystats.healthregen;

            yield return new WaitForSecondsRealtime(time);
        }
        healthfull = false;
    }

    private IEnumerator manaregen()
    {
        while (Mystats.currentMana < Mystats.maxMana)

        {
            Mystats.currentMana = Mystats.currentMana + Mystats.manaRegen;

            yield return new WaitForSecondsRealtime(time);
        }
        manafull = false;
    }

  
}
