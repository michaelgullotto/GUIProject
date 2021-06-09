using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyRebindings : MonoBehaviour
{

    public GameObject settingspanel;
    public GameObject keybindingspanel;
    [SerializeField] Keybinds keybinds;
    public GameObject selectpanel;
    // Start is called before the first frame update

    public Inputmanger inputManager;

    
    //IEnumerator test()
    //{
    //    Debug.Log(key);
    //    yield return 0;
    //    key = KeyCode.A;
        
    //}



    public void Sprintrebind()
    {
        selectpanel.SetActive(true);

        //StartCoroutine( test(keybinds.sprint));
        

        closeSelection();
    }

    public void InvertoryBind()
    {
        selectpanel.SetActive(true);
        keybinds.inventory = KeyCode.A;
        closeSelection();
    }

    public void Jumpbind()
    {
        selectpanel.SetActive(true);
        keybinds.jump = KeyCode.A;
        closeSelection();
    }

    public void InteractBind()
    {
        selectpanel.SetActive(true);
        keybinds.interact = KeyCode.A;
        closeSelection();
    }

    public void ClassablityBind()
    {
        selectpanel.SetActive(true);
        keybinds.classablity = KeyCode.A;
        closeSelection();

    }

    public void RaceAbiltyBind()
    {
        selectpanel.SetActive(true);
        keybinds.raceablity = KeyCode.A;
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
