using UnityEngine;
using System.Collections.Generic;
using System.IO;
using System.Collections;


/*
Data Script which stores and allows access to all of the achievements in the game.
As achievements are implemented, they will be added here.
*/
public static class AchievementData
{
    private static string achievementNamesPath = Path.Combine(Application.streamingAssetsPath, "achievementNames.txt");
    private static string achievementDescriptionsPath = Path.Combine(Application.streamingAssetsPath, "achievementDescriptions.txt");
    private static List<Achievement> ALL_ACHIEVEMENTS = new List<Achievement>();

    public static Achievement GetAchievement(string nameToFind)
    {
        return ALL_ACHIEVEMENTS.Find(i => i.achievementName == nameToFind);
    }
    public static Achievement GetAchievement(int index){
        return ALL_ACHIEVEMENTS[index];
    }
    public static void init()
    {
        string[] temp1 = File.ReadAllLines(achievementNamesPath);
        string[] temp2 = File.ReadAllLines(achievementDescriptionsPath);
        for(int i=0;i<temp1.Length;i++){
            ALL_ACHIEVEMENTS.Add(new Achievement(temp1[i],temp2[i]));
            ALL_ACHIEVEMENTS[i].AddAchievementTrigger(TriggerData.GetTrigger(i));
        }
    }
}
