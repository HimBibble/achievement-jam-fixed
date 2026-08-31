using UnityEngine;
using System.Collections.Generic;
using System.IO;
using System.Collections;


/*
Data Script which stores and allows access to all of the achievements in the game.
*/
public static class AchievementData
{
    private static string ACHIEVEMENT_NAMES_PATH = Path.Combine(Application.streamingAssetsPath, "achievementNames.txt");
    private static string ACHIEVEMENT_DESCRIPTIONS_PATH = Path.Combine(Application.streamingAssetsPath, "achievementDescriptions.txt");
    private static List<Achievement> AllAchievements = new List<Achievement>();
    public static List<Achievement> allAchievements {get {return AllAchievements;} private set {AllAchievements=value;}}
    public static Achievement GetAchievement(string nameToFind)
    {
        return AllAchievements.Find(i => i.achievementName == nameToFind);
    }
    public static Achievement GetAchievement(int index){
        return AllAchievements[index];
    }
    public static void UnlockAchievement(Achievement achievementToUnlock)
    {
        AllAchievements.Find(i => i == achievementToUnlock).isUnlocked=true; // unlocks matching achievement
        Debug.Log("achievement "+achievementToUnlock.achievementName+" unlocked!");
        //Call to whatever code does the funny ui stuff when achievement is unlocked
    }
    public static void init()
    {
        string[] temp1 = File.ReadAllLines(ACHIEVEMENT_NAMES_PATH);
        string[] temp2 = File.ReadAllLines(ACHIEVEMENT_DESCRIPTIONS_PATH);
        for(int i=0;i<temp1.Length;i++){
            AllAchievements.Add(new Achievement(temp1[i],temp2[i]));
            AllAchievements[i].AddAchievementTrigger(TriggerData.GetTrigger(i));
        }
    }
}
