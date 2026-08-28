using UnityEngine;
using System.Collections.Generic;

//script which contains the "Achievement" class.
//Edit this script to alter the functionality of achievements
public class Achievement
{
    private string achievementName;
    private int achievementID;
    private string achievementDescription;
    private bool isUnlocked;
    private List<Trigger> achievementRequirements = new List<Trigger>();
    //do i need to tell you that this is a constructor
    public Achievement(string name, Trigger[] unlockRequirements, bool isUnlocked=false, string achievementDescription="No description added", int achievementID=0){
        //validation!!!
        if(string.IsNullOrEmpty(name)){
             Debug.LogError("New achievement needs a name!");
        }
    }
    //getters and setters
    public string GetAchievementName(){
        return achievementName;
    }
    public int GetAchievementID(){
        return achievementID;
    }
    public string GetAchievementDescription(){
        return achievementDescription;
    }
    public bool GetIsUnlocked(){
        return isUnlocked;
    }
    public List<Trigger> GetAchievementRequirements(){
        return achievementRequirements;
    }
    public void SetAchievementName(string achievementName){
        if(string.IsNullOrEmpty(achievementName)){
            //validation!!!
             Debug.LogError("Can't set achievement "+this.achievementName+" name to nothing!");
        }
        this.achievementName = achievementName;
    }
    public void SetAchievementID(int achievementID){
        this.achievementID=achievementID;
        //check if achievementdata ID already used
    }
    public void SetAchievementDescription(string achievementDescription){
        if(string.IsNullOrEmpty(achievementDescription)){
            //validation!!!
             Debug.LogError("Can't set achievement "+achievementName+" description to nothing!");
        }
        this.achievementDescription = achievementDescription;
    }
    public void SetAchievementRequirements(List<Trigger> achievementRequirements){
        if(achievementRequirements.Count==0){
            Debug.LogError("Achievement "+achievementName+ "unlock requirements are empty!");
        }
        this.achievementRequirements=achievementRequirements;
    }
    public void AddAchievementRequirement(Trigger trigger){
        achievementRequirements.Add(trigger);
    }
    public void RemoveAchievementRequirement(Trigger trigger){
        achievementRequirements.Remove(new Trigger(trigger.GetName()));
    }
    public void unlockAchievement(){
        isUnlocked=true;
        //call to whatever script does funny ui stuff and sound. DONT PUT THE ACTUAL CODE HERE!!!
    }
}

