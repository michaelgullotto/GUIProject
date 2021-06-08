using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inputmanger : MonoBehaviour
{
    public static Inputmanger inputmanger;
    public Keybinds keybinds;

    private void Awake()
    {
        if (inputmanger == null)
        {
            inputmanger = this;
        }
        else if (inputmanger != this)
        {
            Destroy(this);
        }
        DontDestroyOnLoad(this);
    }

    public bool KeyDown (string key)
    {
        if(Input.GetKeyDown(keybinds.CheckKey(key)))
        {
            return true;
        }
        else
        {
            return false;
        }

    }
}
