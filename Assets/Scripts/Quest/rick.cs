using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rick : Npc
{
   // public TalkGoal talk;
    // this dose nothing ATM but is ment to set an id to an npc for questing purposes
     
    private void Start()
    {
        
    }
    public override void Interact()
    {

        //talk.Init();
        CompleteQuests();
        //ID = 1;
        DialogueSystem.instance.AddNewDialogue(dialogue, name);
        Debug.Log("npc");
    }


}
