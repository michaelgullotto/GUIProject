using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

public class Mystats : MonoBehaviour
{
    public GameObject deathpanel;
    public GameObject player;
    public GameObject respawnpoint;
    public AudioSource music;
    public AudioSource ork;
    public AudioSource human;
    public AudioSource mage;
    public AudioSource warrior;
    public AudioSource statstick;
    public AudioSource nostats;
    public AudioSource death;
    [SerializeField] Customisation customisation;

    static public int strength;
    static public int Dextrerity;
    static public int constitution;
    static public int wisdom;
    static public int intelligence;
    static public int charisma;
    static public int poolstrength = 0;
    static public int poolDextrerity = 0;
    static public int poolconstitution = 0;
    static public int poolwisdom = 0;
    static public int poolintelligence = 0;
    static public int poolcharisma = 0;
    static public int basestrength = 0;
    static public int baseDextrerity = 0;
    static public int baseconstitution = 0;
    static public int basewisdom =0;
    static public int baseintelligence =0;
    static public int basecharisma =0;

    static public int level = 1;
    static public int statpool = 10;

    static public int maxhealth = 10;
    static public int healthregen;
    static public int currenthealth;

    static public int Movespeed;
    static public int stamina;
    static public int staminaregen;
    static public int currentstamina = 10;

    static public int maxMana;
    static public int manaRegen;
    static public int currentMana;

    static public string raceAblity;
    static public string raceAblityDes;
    static public string race;
    static public string playerclass;
    static public string classAblity;
    static public string classAblityDes;

    private void Start()
    {
        music.Play();
        levelloader.Index = 2;
       
        
    }
    private void Update()
    {
       
        maxhealth = strength * 20;
        healthregen = strength ;
        maxMana = intelligence * 20;
        manaRegen = intelligence;

        Movespeed = 20 + Dextrerity;
        stamina = Dextrerity * 3;
        staminaregen = Dextrerity / 2;

        if(currentMana > maxMana)
        {
            currentMana = maxMana;
        }

        if (currenthealth > maxhealth)
        {
            currenthealth = maxhealth;
        }

        if (currentstamina > stamina)
        {
            currentstamina = stamina;
        }
        if (currenthealth <= 0)
        {
            Dead();
        }


        strength = poolstrength + basestrength + 5;
        Dextrerity = poolDextrerity + baseDextrerity + 5;
        constitution = poolconstitution + baseconstitution + 5;
        wisdom = poolwisdom + basewisdom + 5;
        intelligence = poolintelligence + baseintelligence + 5;
        charisma = poolcharisma + basecharisma + 5;
    }

    public void SetOrk()
    {
        race = "Ork";
        raceAblity = "Ork Smash";
        raceAblityDes = "Smashes hands into ground doing sending out shockwaves dealing 2x strength + 100 dmg";
        ork.Play();
    }
    public void SetHuman()
    {
        race = "Human";
        raceAblity = "whimper";
        raceAblityDes = "shrieks in fear causeing ememys to be stuned by laughter for 3 seconds";
        human.Play();
    }
    public void SetWarrior()
    {
        playerclass = "Warrior";
        classAblity = "cyclone";
        classAblityDes = "Spins weapons in circles slashing anyone who gets close dealing 1.5 x strength per second";

        basestrength = 10 +(4* level);
        baseDextrerity = 8 + (2 * level);
        baseconstitution = 7 + (1 * level);
        basewisdom = 2 + (1 * level);
        baseintelligence = 1 + (1 * level);
        basecharisma = 5 + (2 * level);
        warrior.Play();
    }
    public void SetMage()
    {
        playerclass = "Mage";
        classAblity = "Fire ball";
        classAblityDes = "Shots a ballof fire. deals 2 x intel + 100 and damage has a 30% chance to ignite ememeys";

        basestrength = 5 + (2 * level);
        baseDextrerity = 3 + (1 * level);
        baseconstitution = 7 + (1 * level);
        basewisdom = 11 + (4 * level);
        baseintelligence = 11 + (6 * level);
        basecharisma = 1 + (1 * level);
        mage.Play();
    }


    public void AddStrength()
    {
        if (statpool > 0)
        {
            statpool--;
            poolstrength++;
            statstick.Play();
        }
        else
        {
            nostats.Play();
        }

    }
    public void MinusStrength()
    {
        if (poolstrength > 0)
        {
            statpool ++;
            poolstrength --;
            statstick.Play();
        }
        else
        {
            nostats.Play();
        }
    }
    public void AddDex()
    {
        if (statpool > 0)
        {
            statpool--;
            poolDextrerity++;
            statstick.Play();
        }
        else
        {
            nostats.Play();
        }

    }
    public void MinusDEX()
    {
        if (poolDextrerity > 0)
        {
            statpool++;
            poolDextrerity--;
            statstick.Play();
        }
        else
        {
            nostats.Play();
        }
    }
    public void AddConstitution()
    {
        if (statpool > 0)
        {
            statpool--;
            poolconstitution++;
            statstick.Play();
        }
        else
        {
            nostats.Play();
        }

    }
    public void MinusConstitution()
    {
        if (poolconstitution > 0)
        {
            statpool++;
            poolconstitution--;
            statstick.Play();
        }
        else
        {
            nostats.Play();
        }
    }
    public void AddWisdom()
    {
        if (statpool > 0)
        {
            statpool--;
            poolwisdom++;
            statstick.Play();
        }
        else
        {
            nostats.Play();
        }

    }
    public void MinusWisdom()
    {
        if (poolwisdom > 0)
        {
            statpool++;
            poolwisdom--;
            statstick.Play();
        }
        else
        {
            nostats.Play();
        }
    }
    public void AddIntel()
    {
        if (statpool > 0)
        {
            statpool--;
           poolintelligence++;
            statstick.Play();
        }
        else
        {
            nostats.Play();
        }

    }
    public void MinusIntel()
    {
        if (poolintelligence > 0)
        {
            statpool++;
            poolintelligence--;
            statstick.Play();
        }
        else
        {
            nostats.Play();
        }
    }
    public void AddCharisma()
    {
        if (statpool > 0)
        {
            statpool --;
            poolcharisma ++;
            statstick.Play();
        }
        else
        {
            nostats.Play();
        }

    }
    public void MinusCharisa()
    {
        if (statpool > 0)
        {
            statpool ++;
            poolcharisma --;
            statstick.Play();
        }
        else
        {
            nostats.Play();
        }
    }
    public void SaveGame()
    {
        
        
        Save save = CreateSaveGameObjects();

        BinaryFormatter bf = new BinaryFormatter();
        FileStream file = File.Create(Application.persistentDataPath + "/gamesave.save");
        bf.Serialize(file, save);
        file.Close();

    }


    private Save CreateSaveGameObjects()
    {
        Save save = new Save();
        
        save.strength =  strength;
        save.Dextrerity = Dextrerity;
        save.constitution = constitution;
        save.wisdom = wisdom;
        save.intelligence = intelligence;
        save.charisma = charisma;
        save.poolstrength = poolstrength;
        save.poolDextrerity = poolDextrerity;
        save.poolconstitution =poolconstitution;
        save.poolwisdom = poolwisdom;
        save.poolintelligence = poolintelligence;
        save.poolcharisma = poolcharisma;
        
        save.race = race;
        save.playerclass = playerclass;
        
        save.level = level;
        save.statpool = statpool;
        save.saveskin = customisation.indexskin;
        save.savehair = customisation.indexhair;
        save.saveeyes = customisation.indexeyes;
        save.savemouth = customisation.indexmouth;
        save.saveclothes = customisation.indexclothes;
        save.savearmour = customisation.indexarmour;

        return save;
    }

    public void loadGame()
    {
       

        if (File.Exists(Application.persistentDataPath + "/gamesave.save"))
        {
            BinaryFormatter bf = new BinaryFormatter();
            FileStream file = File.Open(Application.persistentDataPath + "/gamesave.save", FileMode.Open);
            Save save = (Save)bf.Deserialize(file);
            file.Close();

            strength =      save.strength;   
            Dextrerity =    save.Dextrerity;
            constitution =  save.constitution;
            wisdom =        save.wisdom;
            intelligence =  save.intelligence;
            charisma =      save.charisma;
            poolstrength =  save.poolstrength;
            poolDextrerity = save.poolDextrerity;
            poolconstitution= save.poolconstitution;
            poolwisdom =        save.poolwisdom;
            poolintelligence =  save.poolintelligence;
            poolcharisma = save.poolcharisma;

            race = save.race;
            playerclass = save.playerclass;

            level = save.level;
            statpool = save.statpool;

            customisation.indexskin = save.saveskin;
            Material[] mats = customisation.characterRenderer.materials;
            mats[(int)Customisation.BodyParts.Skin].mainTexture = customisation.skinTextures[customisation.indexskin];



            customisation.indexhair = save.savehair;
            mats[(int)Customisation.BodyParts.Hair].mainTexture = customisation.hairTextures[customisation.indexhair];

            customisation.indexeyes = save.saveeyes;
            mats[(int)Customisation.BodyParts.Eyes].mainTexture = customisation.eyesTextures[customisation.indexeyes];

            customisation.indexmouth = save.savemouth;
            mats[(int)Customisation.BodyParts.Mouth].mainTexture = customisation.mouthTextures[customisation.indexmouth];

            customisation.indexclothes = save.saveclothes;
            mats[(int)Customisation.BodyParts.Clothes].mainTexture = customisation.clothesTextures[customisation.indexclothes];

            customisation.indexarmour = save.savearmour;
            mats[(int)Customisation.BodyParts.Armour].mainTexture = customisation.armourTextures[customisation.indexarmour];


        }

      

        if (race != null)
        {
            if (race == "Ork")
            {
                SetOrk();
            }
            else if (race == "Human")
            {
                SetHuman();
            }
        }
         if(playerclass != null)
        {
            if (playerclass == "Mage")
            {
                SetMage();
            }
            else if (playerclass == "Warrior")
            {
                SetWarrior();
            }

        }
       

    }
    //loads up a panel that player can acess respawn from
    public void Dead()
    {
        Time.timeScale = 0;
        music.Stop();
        death.Play();
        deathpanel.SetActive(true);
    }

    //respawns player at spawn point and resets health to full
    public void respawn()
    {
        Time.timeScale = 1;
        death.Stop();
        music.Play();
        currenthealth = maxhealth;
        player.transform.position = respawnpoint.transform.position;
        deathpanel.SetActive(false);
    }




}
