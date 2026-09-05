using UnityEngine;
using System.Collections.Generic;

public abstract class Interactable : MonoBehaviour
{
    protected float InteractTimer;
    public float interactTimer {get{return InteractTimer;} protected set{InteractTimer=value;}}
    protected float InteractCooldown;
    public float interactCooldown {get{return InteractCooldown;} protected set{InteractCooldown=value;}}
    protected string ASSET_PATH;
    protected string ANIM_PATH;
    protected int currentSprite=1;
    protected List <Sprite> spriteStates;

    public abstract void Interact();
    private void Start()
    {
        
    }
    public void PlayAnimation()
    {

    }
    public void TransitionSprite()
    {
        if(currentSprite<spriteStates.Count){currentSprite++;}
    }
    public void UpdateSprite()
    {
        this.gameObject.GetComponent<SpriteRenderer>().sprite=spriteStates[currentSprite];
    }
    public Sprite ObjectToSprite(Object objToConvert)
    {
        return (objToConvert as Sprite);
    }
}
