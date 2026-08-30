using UnityEngine;
using System.Collections.Generic;
using System.IO;
using System.Collections;

public class Test : MonoBehaviour
{
    private static string achievementNamesPath = Path.Combine(Application.streamingAssetsPath, "achievementNames.txt");
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        string[] temp1 = File.ReadAllLines(achievementNamesPath);
        TriggerData.init();
        AchievementData.init();
        for(int i = 0;i<temp1.Length;i++)
        {
            Achievement achievement = AchievementData.GetAchievement(i);
            Debug.Log(achievement.achievementName);
            Debug.Log(achievement.achievementDescription);
            Debug.Log(achievement.achievementTriggers[0].triggerName);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
