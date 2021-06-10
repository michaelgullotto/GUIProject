using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Npc : Interactable
{
    public string[] dialogue;

    public string name;
    public override void Interact()
    {
        DialogueSystem.instance.AddNewDialogue(dialogue, name);
        Debug.Log("npc");
    }
}
