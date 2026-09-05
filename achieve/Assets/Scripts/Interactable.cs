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
    protected int currentSpriteIndex=0;
    //protected int spriteIndexes;
    protected static GameObject player;
    [SerializeField] protected List <Sprite> spriteStates;

    public abstract void Interact();
    protected void Start()
    {
        player=GameObject.Find("Player");
    }
    public void PlayAnimation()
    {

    }
    public void TransitionSprite()
    {
        if(currentSpriteIndex<spriteStates.Count){currentSpriteIndex++;}
    }
    public void UpdateSprite()
    {
        this.gameObject.GetComponent<SpriteRenderer>().sprite=spriteStates[currentSpriteIndex];
    }
    public Sprite ObjectToSprite(Object objToConvert)
    {
        return (objToConvert as Sprite);
    }
}
