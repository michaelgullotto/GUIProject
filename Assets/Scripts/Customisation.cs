using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.SceneManagement;

public class Customisation : MonoBehaviour
{
    public enum BodyParts { Default, Skin, Eyes, Mouth, Hair, Clothes, Armour };

    public List<Texture2D> skinTextures = new List<Texture2D>();
    public List<Texture2D> hairTextures = new List<Texture2D>();
    public List<Texture2D> mouthTextures = new List<Texture2D>();
    public List<Texture2D> eyesTextures = new List<Texture2D>();
    public List<Texture2D> clothesTextures = new List<Texture2D>();
    public List<Texture2D> armourTextures = new List<Texture2D>();

 
    [SerializeField]
    public int indexskin = 0;
    [SerializeField]
    public int indexeyes = 0;
    [SerializeField]
    public int indexmouth = 0;
    [SerializeField]
    public int indexhair = 0;
    [SerializeField]
    public int indexclothes = 0;
    [SerializeField]
    public int indexarmour = 0;


    // allows player to change textyres for each body part
    public void SelectSkin(int _val)
    {
        if(indexskin + _val < 0)
        {
            indexskin = skinTextures.Count - 1; // loop to back of list if index goes beyond 0;
        }
        else if (indexskin + _val >= skinTextures.Count)
        {
            indexskin = 0;
        }
        else
        {
            indexskin += _val;
        }

        Material[] mats = characterRenderer.materials;
        mats[(int)BodyParts.Skin].mainTexture = skinTextures[indexskin];
  
    }

    public void Selecteyes(int _val)
    {
        if (indexeyes + _val < 0)
        {
            indexeyes = eyesTextures.Count - 1; // loop to back of list if index goes beyond 0;
        }
        else if (indexeyes + _val >= eyesTextures.Count)
        {
            indexeyes = 0;
        }
        else
        {
            indexeyes += _val;
        }

        Material[] mats = characterRenderer.materials;
        mats[(int)BodyParts.Eyes].mainTexture = eyesTextures[indexeyes];
    }

    public void SelectMouth(int _val)
    {
        if (indexmouth + _val < 0)
        {
            indexmouth = mouthTextures.Count - 1; // loop to back of list if index goes beyond 0;
        }
        else if (indexmouth + _val >= mouthTextures.Count)
        {
            indexmouth = 0;
        }
        else
        {
            indexmouth += _val;
        }

        Material[] mats = characterRenderer.materials;
        mats[(int)BodyParts.Mouth].mainTexture = mouthTextures[indexmouth];
    }
    public void SelectHair(int _val)
    {
        if (indexhair + _val < 0)
        {
            indexhair = hairTextures.Count - 1; // loop to back of list if index goes beyond 0;
        }
        else if (indexhair + _val >= hairTextures.Count)
        {
            indexhair = 0;
        }
        else
        {
            indexhair += _val;
        }

        Material[] mats = characterRenderer.materials;
        mats[(int)BodyParts.Hair].mainTexture = hairTextures[indexhair];
    }
    public void Selectcloths(int _val)
    {
        if (indexclothes + _val < 0)
        {
            indexclothes = clothesTextures.Count - 1; // loop to back of list if index goes beyond 0;
        }
        else if (indexclothes + _val >= clothesTextures.Count)
        {
            indexclothes = 0;
        }
        else
        {
            indexclothes += _val;
        }

        Material[] mats = characterRenderer.materials;
        mats[(int)BodyParts.Clothes].mainTexture = clothesTextures[indexclothes];
    }
    public void SelectArmour(int _val)
    {
        if (indexarmour + _val < 0)
        {
            indexarmour = armourTextures.Count - 1; // loop to back of list if index goes beyond 0;
        }
        else if (indexarmour + _val >= armourTextures.Count)
        {
            indexarmour = 0;
        }
        else
        {
            indexarmour += _val;
        }

        Material[] mats = characterRenderer.materials;
        mats[(int)BodyParts.Armour].mainTexture = armourTextures[indexarmour];
    }







    private int[] currentTextureIndex;
    

    //Renderer for our character mesh
    public Renderer characterRenderer;
    
    // prepares extures and varibles on start
    private void Start()
    {
        var parts = Enum.GetValues(typeof(BodyParts));
        currentTextureIndex = new int[parts.Length];

        GrabTextures();
     
    }
    // adds textures to toggle between 
    void GrabTextures()
    {
        //loop through each body part
        foreach (BodyParts part in Enum.GetValues(typeof(BodyParts)))
        {
            Texture2D temporaryTexture;
            int textureCount = 0;

            do// loop through each texture for the body part
            {
                temporaryTexture = (Texture2D)Resources.Load("Warrior Babe/Character/" + part + "_" + textureCount);// as Texture2D;
                if (temporaryTexture != null)
                {
                    switch (part)
                    {
                        case BodyParts.Skin:
                            skinTextures.Add(temporaryTexture);
                            break;
                        case BodyParts.Hair:
                            hairTextures.Add(temporaryTexture);
                            break;
                        case BodyParts.Mouth:
                            mouthTextures.Add(temporaryTexture);
                            break;
                        case BodyParts.Eyes:
                            eyesTextures.Add(temporaryTexture);
                            break;
                        case BodyParts.Clothes:
                            clothesTextures.Add(temporaryTexture);
                            break;
                        case BodyParts.Armour:
                            armourTextures.Add(temporaryTexture);
                            break;
                    }
                }
                textureCount++;
            } while(temporaryTexture != null);
        }
    }


}


