using UnityEngine;
using System.Collections.Generic;

/*
Data Script which contains the "Achievement" class.
Edit this script to alter the functionality of achievements.
Each achievement stores a name, description, whether or not it is unlocked, 
as well as a list of triggers which act as the unlock requirements.
*/
public class Achievement
{
    private string AchievementName;
    public string achievementName
    {
        get {return AchievementName;}
        set 
        {
            if(string.IsNullOrEmpty(value))
            {
                Debug.LogError("Can't set achievement name to null or empty!");
                AchievementName="default achievement";
            }
            else {AchievementName = value;}
        }
    }
    private string AchievementDescription;
    public string achievementDescription
    {
        get {return AchievementDescription;}
        set
        {
        if(string.IsNullOrEmpty(value))
        {
            Debug.LogError("Can't set achievement "+AchievementName+" description to null or empty!");
        }
        this.AchievementDescription = value;
        }
    }
    private bool IsUnlocked;
    public bool isUnlocked {get {return IsUnlocked;} set {IsUnlocked=value;}}
    private List<Trigger> AchievementTriggers=new List<Trigger>();
    public List<Trigger> achievementTriggers {get {return AchievementTriggers;} set {AchievementTriggers=value;}}
    public Achievement(string achievementName, string achievementDescription, List<Trigger> achievementTriggers/*,
    bool isUnlocked=false*/)
    {
        this.achievementName=achievementName;
        this.achievementDescription=achievementDescription;
        this.achievementTriggers=achievementTriggers;
        //this.isUnlocked=isUnlocked;
    }
    
    public void AddAchievementTrigger(Trigger triggerToAdd)
    {
        AchievementTriggers.Add(triggerToAdd);
    }
    public void RemoveAchievementTrigger(Trigger triggerToRemove)
    {
        AchievementTriggers.Remove(new Trigger(triggerToRemove.triggerName));
    }
}

