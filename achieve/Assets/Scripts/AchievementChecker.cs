using UnityEngine;
using System.Collections.Generic;
using System.IO;
using System.Collections;

public class Test : MonoBehaviour
{
    private int frameTimer=0; //used to delay achievement checks
    private List<Trigger> satisfiedTriggers=new List<Trigger>(); //stores triggers with an isTriggered value of true
    private List<Achievement> lockedAchievements = AchievementData.allAchievements;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        TriggerData.init();
        AchievementData.init();
    }

    // Update is called once per frame
    void Update()
    {
        frameTimer++;
        // Checking for achievements is somewhat computationally expensive, so it doesn't need to run every frame
        // It is more efficient to check for individual achievements when relevant triggers flip, but it's annoying to keep up with
        if(frameTimer>5)
        {
            frameTimer=0;
            foreach(Trigger trigger in TriggerData.allTriggers)
            {
                if(trigger.isTriggered==true)
                {
                    satisfiedTriggers.Add(trigger);
                }
            }
            if(satisfiedTriggers.Count>0)
            {
                // this looks like a pretty nasty nested loop, but remember that each achievement only has one trigger currently
                foreach(Achievement lockedAchievement in lockedAchievements)
                {
                    int triggersToSatisfy=lockedAchievement.achievementTriggers.Count;
                    foreach(Trigger satisfiedTrigger in satisfiedTriggers)
                    {
                        foreach(Trigger unlockTrigger in lockedAchievement.achievementTriggers)
                        {
                            //Debug.Log("Checking achievement: "+lockedAchievement.achievementName+ " for trigger: "+unlockTrigger.triggerName);
                            if(satisfiedTrigger==unlockTrigger)
                            {
                                triggersToSatisfy--;
                            }
                        }
                    }
                    if(triggersToSatisfy==0)
                    {
                        AchievementData.UnlockAchievement(lockedAchievement);
                    }
                }
            }
        }
    }
}
