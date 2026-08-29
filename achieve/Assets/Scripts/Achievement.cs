using UnityEngine;
using System.Collections.Generic;

/*
Data Script which contains the "Achievement" class.
Edit this script to alter the functionality of achievements.
Each achievement stores a name, ID, and description, whether or not it is unlocked, 
as well as a list of triggers which act as the unlock requirements.
*/
public class Achievement
{
    private string AchievementName;
    public string achievementName 
    {
        get {return achievementName;}
        set 
        {
            if(string.IsNullOrEmpty(achievementName))
            {
                Debug.LogError("Can't set achievement "+this.achievementName+" name to null or empty!");
            }
        this.achievementName = achievementName;
        }
    }
    private int AchievementID;
    public int achievementID
    {
        get {return achievementID;}
        set 
        {
            this.achievementID=achievementID;
            //IMPLEMENT THIS!! check if achievementdata ID already used
        }
    }
    private string AchievementDescription;
    public string achievementDescription
    {
        get {return AchievementDescription;}
        set
        {
        if(string.IsNullOrEmpty(achievementDescription))
        {
            Debug.LogError("Can't set achievement "+achievementName+" description to null or empty!");
        }
        this.achievementDescription = achievementDescription;
        }
    }
    private bool IsUnlocked;
    public bool isUnlocked {get; set;}
    private List<Trigger> AchievementTriggers = new List<Trigger>();
    public List<Trigger> achievementTriggers
    {
        get {return AchievementTriggers;}
        set
        {
            if(achievementTriggers.Count==0){
                Debug.LogError("Achievement "+achievementName+ "unlock triggers are empty!");
            }
            this.achievementTriggers=achievementTriggers;
        }
    }
    public Achievement(string achievementName="default achievement", List<Trigger> achievementTriggers=null, 
    bool isUnlocked=false, string achievementDescription="No description added", int achievementID=0)
    {
        this.achievementName=achievementName;
        this.achievementTriggers=achievementTriggers;
        this.isUnlocked=isUnlocked;
        this.achievementDescription=achievementDescription;
        this.achievementID=achievementID;
    }
    
    public void AddAchievementTrigger(Trigger triggerToAdd)
    {
        achievementTriggers.Add(triggerToAdd);
    }
    public void RemoveAchievementTrigger(Trigger triggerToRemove)
    {
        achievementTriggers.Remove(new Trigger(triggerToRemove.triggerName));
    }
    public void UnlockAchievement()
    {
        isUnlocked=true;
        //IMPLEMENT THIS!!! Call to whatever script does funny ui stuff and sound. 
    }
}

