using UnityEngine;
using System.Collections.Generic;
using System.IO;
using System.Collections;

public class AchievementChecker : MonoBehaviour
{
    private static int unlockCounter=0;
    private static List<Achievement> achievementsToUnlock=new List<Achievement>();
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Awake()
    {
        TriggerData.init();
        AchievementData.init();
        /*foreach(Achievement achievement in AchievementData.lockedAchievements){
        Debug.Log(achievement.achievementName+": "+achievement.achievementDescription+" Unlocked by: "+achievement.achievementTriggers[0].triggerName);
        }*/

    }

    // Update is called once per frame
    void Update()
    {
        // It is more efficient to check for individual achievements when relevant triggers flip, but it's annoying to keep up with
        if(TriggerData.onTriggers.Count>0)
        {
            // this looks like a pretty nasty nested loop, but remember that each achievement only has at most one trigger currently
            foreach(Achievement lockedAchievement in AchievementData.lockedAchievements)
            {
                int triggersToSatisfy=lockedAchievement.achievementTriggers.Count;
                foreach(Trigger onTrigger in TriggerData.onTriggers)
                {
                    foreach(Trigger unlockTrigger in lockedAchievement.achievementTriggers)
                    {
                        //Debug.Log("Checking achievement: "+lockedAchievement.achievementName+ " for trigger: "+unlockTrigger.triggerName);
                        if(onTrigger.triggerName==unlockTrigger.triggerName)
                        {
                            triggersToSatisfy--;
                        }
                    }
                }
                if(triggersToSatisfy==0)
                {
                    //queues achievement for unlocking after update loop is finished and will not add duplicates
                    if (!achievementsToUnlock.Contains(lockedAchievement)) {achievementsToUnlock.Add(lockedAchievement);}
                    unlockCounter++;
                    //check for achievements unlocked from having a certain number of achievements
                    if(unlockCounter==1){
                        TriggerData.SetTrigger("Achievement",true);
                    }
                    else if(unlockCounter==10){
                        TriggerData.SetTrigger("Achievement10",true);
                    }
                    else if(unlockCounter==50){
                        TriggerData.SetTrigger("Achievement50",true);
                    }
                    else
                    {
                        TriggerData.SetTrigger("Achievement",false);
                        TriggerData.SetTrigger("Achievement10",false);
                        TriggerData.SetTrigger("Achievement50",false);
                    }
                }
            }
        }
        for(int i =0;i<achievementsToUnlock.Count;i++)
        {
            AchievementData.UnlockAchievement(achievementsToUnlock[i]);
            achievementsToUnlock.RemoveAt(i);
        }
    }
}
