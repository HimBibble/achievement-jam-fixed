using UnityEngine;

//script which contains the "Trigger" class.
//Edit this script to alter the functionality of achievement triggers

public class Trigger
{
    private string name;
    private bool isTriggered;
    //do i need to tell you that this is a constructor
    public Trigger(string name, bool isTriggered=false){
        //validation!!!
        if(string.IsNullOrEmpty(name)){
             Debug.LogError("New trigger needs a name!");
        }
    }
    //getters and setters
    public string GetName(){
        return name;
    }
    public bool GetIsTriggered(){
        return isTriggered;
    }
    public void SetName(string name){
        if(string.IsNullOrEmpty(name)){
            //validation!!!
             Debug.LogError("Can't set trigger name to nothing!");
        }
        this.name = name;
    }
    public void SetIsTriggered(bool isTriggered){
        this.isTriggered = isTriggered;
    }
}
