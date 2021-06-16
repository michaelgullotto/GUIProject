using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class KeyBindUI : MonoBehaviour
{
    public KeyBinds keybinds;

    public TMP_Text text;


    public void ChangeKeybinds(string keyBind)
    {

        StartCoroutine(listenForKeyChange(keyBind));
    }

    IEnumerator listenForKeyChange(string keyBind)
    {
        KeyCode keyCode;
        do
        {
            keyCode = keybinds.GetKeyPressed();
            yield return 0;
        } while (keyCode == KeyCode.None);

        keybinds.ChangeKeyBind(keyBind, keyCode);

        text.text = keyCode.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        if (keybinds.GetKeyDown("Forward"))
        {   
            Debug.Log("HI IM MOVING FORWARD");
        }
    }
}
