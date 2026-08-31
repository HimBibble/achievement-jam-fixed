using UnityEngine;
using System.Collections.Generic;
using System.IO;
using System.Collections;

/*
Data Script which stores and allows access to all of the triggers in the game.
*/
public static class TriggerData
{
    private static string TRIGGER_DATA_PATH = Path.Combine(Application.streamingAssetsPath, "achievementData.txt");
    private static List<Trigger> OffTriggers = new List<Trigger>();
    public static List<Trigger> offTriggers {get {return OffTriggers;} private set {OffTriggers=value;}}
    private static List<Trigger> OnTriggers = new List<Trigger>();
    public static List<Trigger> onTriggers {get {return OnTriggers;} private set {OnTriggers=value;}}

    public static Trigger GetOffTrigger(string nameToFind){
        return OffTriggers.Find(i => i.triggerName == nameToFind);
    }
    public static Trigger GetOffTrigger(int index){
        return OffTriggers[index];
    }
    public static Trigger GetOnTrigger(string nameToFind){
        return OnTriggers.Find(i => i.triggerName == nameToFind);
    }
    public static Trigger GetOnTrigger(int index){
        return OnTriggers[index];
    }
    public static void SetTrigger(string triggerNameToSet, bool value){
        if(value==false)
        {
            Trigger trigger=OffTriggers.Find(i => i.triggerName == triggerNameToSet);
            if(trigger!=null)
            {
                //remove trigger from onTriggers and add it to offTriggers
                OnTriggers.Remove(trigger);
                OffTriggers.Add(trigger);
            }

        }
        else
        {
            Trigger trigger=OffTriggers.Find(i => i.triggerName == triggerNameToSet);
            if(trigger!=null)
            {
                //remove trigger from offTriggers and add it to onTriggers
                OffTriggers.Remove(trigger);
                OnTriggers.Add(trigger);
            }
        }
        
    }
    public static void init()
    {
        string[] temp1 = File.ReadAllLines(TRIGGER_DATA_PATH);
        for(int i=0;i<temp1.Length;i++){
            string[] temp2 = temp1[i].Split(";");
            for(int j=0;j<temp2.Length;j++){
            }
            for(int j=2;j<temp2.Length;j++)
            {
                OffTriggers.Add(new Trigger(temp2[j]));
            }
        }
    }
}
