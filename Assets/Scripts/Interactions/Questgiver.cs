using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Questgiver : Npc
{
    public AudioSource arrrr;
    public bool AssignedQuest { get; set;}
    public bool Helped { get; set;}
    [SerializeField]
    private GameObject quests;
    [SerializeField]
    private string questType;
    private Quest Quest { get; set; }
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

    void AssignQuest()
    {
        AssignedQuest = true;
        Quest = (Quest)quests.AddComponent(System.Type.GetType(questType));

    }

    void CheckQuest()
    {
        if (Quest.Completed)
        {
            Quest.Givereward();
            Helped = true;
            AssignedQuest = false;

            DialogueSystem.instance.AddNewDialogue(new string[] { "although he is strange his song is beautiful" , "You have completed the quest " }, name);
        }
        else if(!Quest.Completed)
        {
            DialogueSystem.instance.AddNewDialogue(new string[] { "YOU HAVENT TALKED TO RICK" }, name);
            arrrr.Play();
            Mystats.currenthealth = Mystats.currenthealth - 69;
        }
    }
}


