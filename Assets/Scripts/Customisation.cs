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

    //public GameObject leftbuton;
    //public GameObject rightbutton;

    //public int skinsave;
    //public int hairsave;
    //public int mouthsave;
    //public int eyesave;
    //public int clothsave;
    //public int armoursave;
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
    //skinTextures[0] = Skin_0
    //skinTextures[1] = Skin_1
    //skinTextures[2] = Skin_2

    //Renderer for our character mesh
    public Renderer characterRenderer;
    
    private void Start()
    {
        var parts = Enum.GetValues(typeof(BodyParts));
        currentTextureIndex = new int[parts.Length];

        GrabTextures();
        /*
        for(int x = 0; x < parts.Length; x++)
        {
            BodyParts part = (BodyParts)parts.GetValue(x);
            currentTextureIndex[x] = PlayerPrefs.GetInt(part + "texture", 0);
            SetTexture(part, 0);
        }
        */
    }

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

/*    void SetTexture(BodyParts bodyPart, int direction)
    {

        

        List<Texture2D> textures;
        switch (bodyPart)
        {
            case BodyParts.Skin:
                textures = skinTextures;
                break;
            case BodyParts.Hair:
                textures = hairTextures;
                break;
            case BodyParts.Mouth:
                textures = mouthTextures;
                break;
            case BodyParts.Eyes:
                textures = eyesTextures;
                break;
            case BodyParts.Clothes:
                textures = clothesTextures;
                break;
            case BodyParts.Armour:
                textures = armourTextures;
                break;
            default:
                return;
        }

        


        int partsIndex = (int)bodyPart;
        partsIndex++;//add one to skip the default material
        int partsCount = textures.Count;

        //currentTexture

        //allows the choice
        currentTextureIndex[(int)bodyPart] += direction;
        if(currentTextureIndex[(int)bodyPart] < 0)
        {
            currentTextureIndex[(int)bodyPart] = partsCount - 1;//go to the end
        }
        else if(currentTextureIndex[(int)bodyPart] > partsCount - 1)
        {
            currentTextureIndex[(int)bodyPart] = 0;//go to the start
        }


        //we are currently at this skin texture;
        //skinTextures[currentTextureIndex]

        Material[] mats = characterRenderer.materials;
        int x = currentTextureIndex[(int)bodyPart];
        mats[partsIndex].mainTexture = textures[x];
        characterRenderer.materials = mats;


        PlayerPrefs.SetInt(bodyPart + "texture", currentTextureIndex[(int)bodyPart]);
    }
*/


    private void OnGUI()
    {
        //CustomiseOnGUI();
        //custom();
        
    }

    //private void CustomiseOnGUI()
    //{
    //    float currentY = 40;

        

    //    GUI.Box(new Rect(10, 10, 110, 210), "Visuals");

    //    foreach(BodyParts part in Enum.GetValues(typeof(BodyParts)))
    //    {
    //        if (GUI.Button(new Rect(20, currentY, 20, 20), "<"))
    //        {
    //            SetTexture(part, -1);
    //        }
    //        GUI.Label(new Rect(45, currentY, 60, 20), part.ToString());
    //        if (GUI.Button(new Rect(90, currentY, 20, 20), ">"))
    //        {
    //            SetTexture(part, 1);
    //        }
    //        currentY += 30;
       // }
    //}

    //private void custom()
    //{
        
    //    float currentY = 40;
    //    Vector3 leftspawnpos = new Vector3();
    //    leftspawnpos.y = currentY;
    //    leftspawnpos.x = 20;

    //    foreach (BodyParts part in Enum.GetValues(typeof(BodyParts)))
    //    {
    //         Instantiate(leftbuton, leftspawnpos, Quaternion.identity);
           



    //        currentY += 30;
    //    }


    //}

    //public void addSkin()
    //{
    //    SetTexture(part, 1);
    //}




}


