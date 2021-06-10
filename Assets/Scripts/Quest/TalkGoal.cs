using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TalkGoal : Goal
{
    public int NpcID;
    
    // Start is called before the first frame update

    public TalkGoal(Quest quest,int npcID,string description, bool completed, int currentAmount , int requiredAmount )
    {
        this.Quest = quest;
        this.NpcID = npcID;
        this.Description = description;
        this.Completed = completed;
        this.CurrentAmount = currentAmount;
        this.RequiredAmount = requiredAmount;
    }

    public override void Init()
    {
        base.Init();
       // CorrectNpc();
    }


    void CorrectNpc(rick npc)
    {
        if (npc.ID == this.NpcID)
        {
            this.CurrentAmount++;
            Evaluate();
        }
    }
        

}
