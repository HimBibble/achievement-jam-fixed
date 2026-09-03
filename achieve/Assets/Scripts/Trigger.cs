using UnityEngine;
using System.Collections.Generic;

/*
Data Script which contains the "Trigger" class.
Edit this script to alter the functionality of achievement triggers.
Each trigger stores its name, and whether or not it is triggered.
The logic behind triggers lies within the code for the relevant mechanic.
Example: movement code will activate movement-based triggers. Trigger logic is not stored in the trigger itself.
This script also contains extra comments regarding c# properties (automatic getter/setters), if needed.
*/


public class Trigger
{
    //variables use c# properties for automatic getters and setters
    private string TriggerName; //variable
    public string triggerName //custom properties
    {
        get {return TriggerName;}
        set
        {
            if(string.IsNullOrEmpty(value)) //validation
            {
                Debug.LogError("Trigger name is null or empty!");
                TriggerName="default trigger";
            }
            else {TriggerName = value;} //fills variable TriggerName with implicit string argument value
        }
    }
    /*private bool IsTriggered;
    public bool isTriggered {get {return IsTriggered;} set {IsTriggered=value;}}*/
    public Trigger(string triggerName/*, bool isTriggered=false*/)
    {
        this.triggerName=triggerName; //calls setter from property triggerName
        //this.isTriggered=isTriggered; //calls setter from property isTriggered
        
    }
}
