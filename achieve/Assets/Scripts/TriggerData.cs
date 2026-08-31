using UnityEngine;
using System.Collections.Generic;
using System.IO;
using System.Collections;

/*
Data Script which stores and allows access to all of the triggers in the game.
*/
public static class TriggerData
{
    private static string triggerNamesPath = Path.Combine(Application.streamingAssetsPath, "triggerNames.txt");
    private static List<Trigger> AllTriggers = new List<Trigger>();
    public static List<Trigger> allTriggers {get {return AllTriggers;} private set {AllTriggers=value;}}
    
    public static Trigger GetTrigger(string nameToFind){
        return AllTriggers.Find(i => i.triggerName == nameToFind);
    }
    public static Trigger GetTrigger(int index){
        return AllTriggers[index];
    }
    public static void SetTrigger(string triggerNameToSet, bool value){
        AllTriggers.Find(i => i.triggerName == triggerNameToSet).isTriggered=value;
    }
    public static void init()
    {
        string[] temp = File.ReadAllLines(triggerNamesPath);
        for(int i=0;i<temp.Length;i++){
            AllTriggers.Add(new Trigger(temp[i]));
        }
    }
}
