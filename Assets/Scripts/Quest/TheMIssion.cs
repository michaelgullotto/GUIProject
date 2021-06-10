using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TheMission : Quest
{
    // Start is called before the first frame update
    void Start()
    {
        QuestName = "THE MISSION";
        Desciption = "Talk to Rick";

        Goals.Add(new TalkGoal(this, 0, "talk to Rick", false, 0, 1));

        Goals.ForEach(g => g.Init());

    }

}
