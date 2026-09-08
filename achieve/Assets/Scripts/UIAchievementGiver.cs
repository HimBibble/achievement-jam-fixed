using UnityEngine;
using System.Collections.Generic;

public class UIAchievementGiver : MonoBehaviour
{
    private float timer;
    private float INTERVAL=1f;
    private List<string> triggersToDeactivate=new List<string>();
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timer-=Time.deltaTime;
        if(timer<0f&&triggersToDeactivate.Count>0)
        {
            for(int i=triggersToDeactivate.Count-1;i>0;i--)
            {
                TriggerData.SetTrigger(triggersToDeactivate[i],false);
                triggersToDeactivate.RemoveAt(i);
            }
            timer=INTERVAL;
        }
    }
    public void SetUITrigger(string triggerName)
    {
        TriggerData.SetTrigger(triggerName,true);
        triggersToDeactivate.Add(triggerName);
        timer=INTERVAL;
    }
}
