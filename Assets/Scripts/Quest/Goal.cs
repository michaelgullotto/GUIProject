using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Goal
{
    public Quest Quest { get; set;}
    public string Description { get; set;}
    public bool Completed { get; set;}
    public int CurrentAmount { get; set;}
    public int RequiredAmount { get; set;}
    // empty cause get ovrided in other scrips using this base class
    public virtual void Init()
    {

    }
    //checks if complete
    public void Evaluate()
    {
        if (CurrentAmount >= RequiredAmount)
        {
            Complete();
        }
    }
    // changes bool to when complete
    public void Complete()
    {
        Quest.CheckGoals();
        Completed = true; 
    }


}

