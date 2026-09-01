using UnityEditor;
using UnityEngine;
using UnityEngine.UIElements;

public class InputAchievementGiver : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //this is just checking for each of the inputs that give achievements and activating the necessary triggers
        if (Input.GetKeyDown("1")){TriggerData.SetTrigger("Key1",true);}
        else{TriggerData.SetTrigger("Key1",false);}
        if (Input.GetKeyDown("2")){TriggerData.SetTrigger("Key2",true);}
        else{TriggerData.SetTrigger("Key2",false);}
        if (Input.GetKeyDown("3")){TriggerData.SetTrigger("Key3",true);}
        else{TriggerData.SetTrigger("Key3",false);}
        if (Input.GetKeyDown("4")){TriggerData.SetTrigger("Key4",true);}
        else{TriggerData.SetTrigger("Key4",false);}
        if (Input.GetKeyDown("5")){TriggerData.SetTrigger("Key5",true);}
        else{TriggerData.SetTrigger("Key5",false);}
        if (Input.GetKeyDown("6")){TriggerData.SetTrigger("Key6",true);}
        else{TriggerData.SetTrigger("Key6",false);}
        if (Input.GetKeyDown("7")){TriggerData.SetTrigger("Key7",true);}
        else{TriggerData.SetTrigger("Key7",false);}
        if (Input.GetKeyDown("8")){TriggerData.SetTrigger("Key8",true);}
        else{TriggerData.SetTrigger("Key8",false);}
        if (Input.GetKeyDown("9")){TriggerData.SetTrigger("Key9",true);}
        else{TriggerData.SetTrigger("Key9",false);}
        if (Input.GetKeyDown("0")){TriggerData.SetTrigger("Key0",true);}
        else{TriggerData.SetTrigger("Key0",false);}
        if (Input.GetMouseButtonDown(0)){TriggerData.SetTrigger("LeftMouse",true);}
        else{TriggerData.SetTrigger("LeftMouse",false);}
        if (Input.GetMouseButtonDown(1)){TriggerData.SetTrigger("RightMouse",true);}
        else{TriggerData.SetTrigger("RightMouse",false);}

        if (Input.GetMouseButtonDown(2)){TriggerData.SetTrigger("MiddleMouse",true);}
        else{TriggerData.SetTrigger("MiddleMouse",false);}
    }
}
