using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inputmanger : MonoBehaviour
{
    public static Inputmanger inputmanger;
    public Keybinds keybinds;

    KeyCode pressed;

    // makes sure there is only one inputmanger
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
    // check what key is pressed and if it matchs an input
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
    public bool Key(string key)
    {
        if (Input.GetKey(keybinds.CheckKey(key)))
        {
            return true;
        }
        else
        {
            return false;
        }
    }
    public bool KeyUp (string key)
    {
        if (Input.GetKeyUp(keybinds.CheckKey(key)))
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    public KeyCode GetPressedKeycode()
    {
        return pressed;
    }


    // anderws code helping with rebinding
    private void OnGUI()
    {
        if (Event.current.isKey && Event.current.type == EventType.KeyDown)
        {
            Event e = Event.current;

            pressed = e.keyCode;
        }
        else
        {
            pressed = KeyCode.None;
        }

    }
}
