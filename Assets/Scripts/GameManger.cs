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
        mystats.loadGame();
      
        levelloader.Index = 3;
        //Mystats loadGame()

    }

    // Update is called once per frame
    void Update()
    {
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
