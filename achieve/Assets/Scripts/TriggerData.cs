using UnityEngine;
using System.Collections.Generic;
using System.IO;
using System.Collections;

/*
Data Script which stores and allows access to all of the triggers in the game.
As triggers are implemented, they will be added here.
*/
public static class TriggerData
{
    private static string triggerNamesPath = Path.Combine(Application.streamingAssetsPath, "triggerNames.txt");
    private static List<Trigger> ALL_TRIGGERS = new List<Trigger>();
    
    public static Trigger GetTrigger(string nameToFind){
        return ALL_TRIGGERS.Find(i => i.triggerName == nameToFind);
    }
    public static Trigger GetTrigger(int index){
        return ALL_TRIGGERS[index];
    }
    public static void init()
    {
        string[] temp = File.ReadAllLines(triggerNamesPath);
        for(int i=0;i<temp.Length;i++){
            ALL_TRIGGERS.Add(new Trigger(temp[i]));
        }
    }
}
