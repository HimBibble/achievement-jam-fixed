using UnityEngine;

public class TimerAchievement : MonoBehaviour
{
    public float aliveTimer=0f;
    // Update is called once per frame
    void Update()
    {
        aliveTimer+=Time.deltaTime;
        if(aliveTimer>10f){TriggerData.SetTrigger("Alive10",true);}
        else{TriggerData.SetTrigger("Alive10",false);}
        if(aliveTimer>30f){TriggerData.SetTrigger("Alive30",true);}
        else{TriggerData.SetTrigger("Alive30",false);}
        if(aliveTimer>300f){TriggerData.SetTrigger("Alive300",true);}
        else{TriggerData.SetTrigger("Alive300",false);}
    }
}
