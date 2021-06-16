using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class TalkGoal : Goal
{
    public int NpcID;
    
    // Start is called before the first frame update

    // grabs all the required varribles for the quest type
    public TalkGoal(Quest quest,int npcID,string description, bool completed, int currentAmount , int requiredAmount )
    {
        this.Quest = quest;
        this.NpcID = npcID;
        this.Description = description;
        this.Completed = completed;
        this.CurrentAmount = currentAmount;
        this.RequiredAmount = requiredAmount;
    }
    // calls the corect noc on interact event
    public override void Init()
    {
        base.Init();
        
    }

    // adds to goal when condition is met
    //void CorrectNpc(rick npc)
    //{
    //    if (npc.ID == this.NpcID)
    //    {
    //        this.CurrentAmount++;
    //        Evaluate();
    //    }
    //}
        

}
