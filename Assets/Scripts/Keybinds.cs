using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu(fileName = "keybindings", menuName = "keybindings")]
public class Keybinds : ScriptableObject
{

    public KeyCode jump, interact, sprint, inventory, classablity, raceablity;

    public KeyCode CheckKey(string key)
    {
        switch(key)
        {
            case "Jump":
                return jump;
            case "Interact":
                return interact;
            case "Sprint":
                return sprint;
            case "Inventory":
                return inventory;
            case "Classablity":
                return classablity;
            case "Raceablity":
                return raceablity;
            default:
                return KeyCode.None;
        }
    }
}
