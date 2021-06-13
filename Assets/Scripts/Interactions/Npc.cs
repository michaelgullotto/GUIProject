using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Npc : Interactable
{
    // base class for npcs
    public string[] dialogue;

    public string name;
    // tells game to override interact to  npc interact
    public override void Interact()
    {
        DialogueSystem.instance.AddNewDialogue(dialogue, name);
        Debug.Log("npc");
    }
}
