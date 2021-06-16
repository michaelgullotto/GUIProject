using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Npc : Interactable
{
    // base class for npcs
    public string[] dialogue;
    public int ID = 0;
    public string name;

    public Quest giveQuest;
    public string completeQuest;


    [SerializeField]
    protected GameObject quests;

    // tells game to override interact to  npc interact
    public override void Interact()
    {

        DialogueSystem.instance.AddNewDialogue(dialogue, name);
        Debug.Log("npc");


    }
    protected void CompleteQuests()
    {
        foreach (Quest quest in quests.GetComponentsInChildren<Quest>())
        {
            if (quest.QuestName == completeQuest)
            {
                bool isAllGoalsComplete = true;
                foreach (Goal goal in quest.Goals)
                {
                    goal.CurrentAmount += 1;
                    if (goal.CurrentAmount >= goal.RequiredAmount)
                    {
                        goal.Completed = true;
                    }
                    else if(goal.Completed == false)
                    {
                        isAllGoalsComplete = false;
                    }
                }

                if(isAllGoalsComplete)
                {
                    quest.Completed = true;
                }
            }
        }
        
        
    }

    //public void CheckForQuests()
    //{
    //    if (giveQuest.QuestName != "")
    //    {
    //        //give player this quest 
    //        //(add quest to player)
    //    }

    //    if (completeQuest != "")
    //    {
    //        // loop foreach quest on player, check Quest.name == completeQuest)
    //        //if - match, 
    //        //complete completeQuest;
    //    }
    //}
}
