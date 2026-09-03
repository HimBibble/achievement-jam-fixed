using UnityEngine;
using System.Collections.Generic;
using UnityEditor;
using System.Linq;
using System;

public class TreeTile : Interactable
{

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    protected virtual void Start()
    {
        ASSET_PATH = "Assets/2D Assets/Venus_Flytrap/Venus_Flytrap_SpriteSheet.png";
        ANIM_PATH = "Assets/2D Assets/Venus_Flytrap/Venus_Flytrap_SpriteSheet.png";
        interactCooldown=0.75f;
        this.gameObject.tag="Squawk";
        spriteStates = AssetDatabase.LoadAllAssetsAtPath(ASSET_PATH).ToList().ConvertAll(new Converter<UnityEngine.Object, Sprite>(ObjectToSprite));
        UpdateSprite();
    }

    // Update is called once per frame
    protected virtual void Update()
    {
        if(interactTimer<0f){TriggerData.SetTrigger("InteractTree",false);}
    }
    public override void Interact()
    {
        if(interactTimer<=0f)
        {
            //play animation
            UpdateSprite();
            interactTimer=interactCooldown;
            TriggerData.SetTrigger("InteractTree",true);
        }
    }
}
