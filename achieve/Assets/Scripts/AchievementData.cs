using UnityEngine;
using System.Collections.Generic;
using System.IO;
using System.Collections;


/*
Data Script which stores and allows access to all of the achievements in the game.
*/
public static class AchievementData
{
    private static string ACHIEVEMENT_DATA_PATH = Path.Combine(Application.streamingAssetsPath, "achievementData.txt");
    private static List<Achievement> LockedAchievements = new List<Achievement>();
    public static List<Achievement> lockedAchievements {get {return LockedAchievements;} private set {LockedAchievements=value;}}
    private static List<Achievement> UnlockedAchievements = new List<Achievement>();
    public static List<Achievement> unlockedAchievements {get {return UnlockedAchievements;} private set {UnlockedAchievements=value;}}
    public static Achievement GetAchievement(string nameToFind)
    {
        Achievement foundAchievement = UnlockedAchievements.Find(i => i.achievementName == nameToFind);
        if(foundAchievement!=null){return foundAchievement;}
        else
        {
            return(LockedAchievements.Find(i => i.achievementName == nameToFind));
        }
        
    }
    public static void UnlockAchievement(Achievement achievementToUnlock)
    {
        LockedAchievements.Remove(achievementToUnlock);
        UnlockedAchievements.Add(achievementToUnlock);
        Debug.Log("Achievement: "+achievementToUnlock.achievementName+" unlocked!");
        //call to code for funny ui stuff when unlocking achievements
    }
    public static void init()
    {
        string[] temp1 = File.ReadAllLines(ACHIEVEMENT_DATA_PATH);
        for(int i=0;i<temp1.Length;i++)
        {
            string[] temp2 = temp1[i].Split(";");
            LockedAchievements.Add(new Achievement(temp2[0],temp2[1],new List<Trigger>()));
            for(int j=2;j<temp2.Length;j++)
            {
                LockedAchievements[i].AddAchievementTrigger(TriggerData.GetOffTrigger(temp2[j]));
            }
        }
    }
}
