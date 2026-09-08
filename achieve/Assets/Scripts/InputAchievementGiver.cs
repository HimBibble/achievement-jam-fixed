using UnityEditor;
using UnityEngine;
using System.Collections.Generic;
using UnityEngine.UIElements;

public class InputAchievementGiver : MonoBehaviour
{
    private static List<string> KONAMI_CODE = new List<string>() {"Up","Up","Down","Down","Left","Right","Left","Right","B","A"};
    private static List<string> myCode = new List<string>();
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
        //mouse
        if (Input.GetMouseButton(0)){TriggerData.SetTrigger("LeftMouse",true);}
        else{TriggerData.SetTrigger("LeftMouse",false);}
        if (Input.GetMouseButtonDown(1)){TriggerData.SetTrigger("RightMouse",true);}
        else{TriggerData.SetTrigger("RightMouse",false);}
        if (Input.GetMouseButtonDown(2)){TriggerData.SetTrigger("MiddleMouse",true);}
        else{TriggerData.SetTrigger("MiddleMouse",false);}
        //konami code
        if (Input.GetKeyDown(KeyCode.UpArrow)){myCode.Add("Up");}
        if (Input.GetKeyDown(KeyCode.DownArrow)){myCode.Add("Down");}
        if (Input.GetKeyDown(KeyCode.LeftArrow)){myCode.Add("Left");}
        if (Input.GetKeyDown(KeyCode.RightArrow)){myCode.Add("Right");}
        if (Input.GetKeyDown(KeyCode.A)){myCode.Add("A");}
        if (Input.GetKeyDown(KeyCode.B)){myCode.Add("B");}
        /*int successfulInputs=0;
        if(myCode.Count>0)
        {
            if(myCode.Count>10){
                Clear();
            }
            for(int i =0;i<myCode.Count;i++)
            {
                //Debug.Log(myCode[i]);
                if(myCode[i]==KONAMI_CODE[i])
                {
                    successfulInputs++;
                    //Debug.Log(successfulInputs);
                    //Clear(); //because clearing inside the loop results in an error
                    //return;
                }
                else{
                    Clear();
                    return;
                }
            }
            if(successfulInputs==10){
            TriggerData.SetTrigger("KonamiCode",true);}
            Clear();
            successfulInputs=0;
        }*/
        
    }
    private void Clear()
    {
        myCode.Clear();
    }
}
