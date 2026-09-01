using UnityEngine;

public abstract class Interactable : MonoBehaviour
{
    private float InteractCooldown;
    public float interactCooldown {get{return InteractCooldown;} set{InteractCooldown=value;}}
    private string InteractMethod;
    public string interactMethod {get{return InteractMethod;} set{InteractMethod=value;}}

    public abstract void Interact();
    private void Start()
    {
        this.gameObject.tag=interactMethod;
        /*if(this.gameObject.tag=="Overlap")
        {
            
        }
        else if(this.gameObject.tag=="Squawk")
        {
            
        }*/
    }
}
