using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Questgiver : Npc
{
    public AudioSource arrrr;
    public bool AssignedQuest { get; set;}
    public bool Helped { get; set;}

    [SerializeField]
    private string questType;
    private Quest Quest { get; set; }

    // assigns quest or checks if quest is complete if assigned already when interacted with
    public override void Interact()
    {
        base.Interact();
        if (!AssignedQuest && !Helped)
        {
            AssignQuest();
        }
        else if (AssignedQuest && !Helped)
        {
            CheckQuest();
        }
       
    }
    // asigns quest
    void AssignQuest()
    {
        AssignedQuest = true;
        Quest = (Quest)quests.AddComponent(System.Type.GetType(questType));

    }
    // quest competions check
    void CheckQuest()
    {
        // if compelete gives your reward
        if (Quest.Completed == true)
        {
            Quest.Givereward();
            Helped = true;
            AssignedQuest = false;

            DialogueSystem.instance.AddNewDialogue(new string[] { "although he is strange his song is beautiful" , "You have completed the quest " }, name);
        }
        // if not complete gives you a smack
        else if(!Quest.Completed)
        {
            DialogueSystem.instance.AddNewDialogue(new string[] { "YOU HAVENT TALKED TO RICK" }, name);
            arrrr.Play();
            Mystats.currenthealth = Mystats.currenthealth - 69;
        }
    }
}


