using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class Quest : MonoBehaviour
{
    public List<Goal> Goals { get; set; } = new List<Goal>();
    public string QuestName { get; set; }
    public string Desciption { get; set; }
    public int ExperienceReward {get;set;}
    //public Item itemReward { get; set;}
    public bool Completed { get; set; }
   
    // checks if complete
    public void CheckGoals()
    {
        Completed = Goals.All(g => g.Completed);
        
    }
    // gives reward on complete
    public void Givereward()
    {
        
    }


}
