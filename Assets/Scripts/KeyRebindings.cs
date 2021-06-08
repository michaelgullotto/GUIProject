using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyRebindings : MonoBehaviour
{
    
    public GameObject settingspanel;
    public GameObject keybindingspanel;
    Keybinds keybinds;
    public GameObject selectpanel;
    // Start is called before the first frame update
   public void Sprintrebind()
    {
        selectpanel.SetActive(true);
        keybinds.sprint = KeyCode.A;
        closeSelection();
    }

    public void closeSelection()
    {
        selectpanel.SetActive(false);
    }

    public void backtosettings()
    {
        keybindingspanel.SetActive(false);
        settingspanel.SetActive(true);
    }
    public void keybindsOpen()
    {
        keybindingspanel.SetActive(true);
        settingspanel.SetActive(false);
    }
}
