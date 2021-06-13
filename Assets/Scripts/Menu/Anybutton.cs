using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Anybutton : MonoBehaviour
{

    public GameObject press;
    public GameObject mainMenu;

    //press and button to load menu
    void Update()
    {

        if (Input.anyKey)
        {
            press.SetActive(false);
            mainMenu.SetActive(true);

        }


    }
}
