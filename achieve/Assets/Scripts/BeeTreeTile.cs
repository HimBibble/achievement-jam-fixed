using UnityEngine;
using System.Collections.Generic;
using UnityEditor;
using System.Linq;
using System;

public class BeeTreeTile : TreeTile
{
    private bool isInteracted;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    protected override void Start()
    {
        string ASSET_PATH = "Assets/2D Assets/Venus_Flytrap/Venus_Flytrap_SpriteSheet.png";
        string ANIM_PATH = "Assets/2D Assets/Venus_Flytrap/Venus_Flytrap_SpriteSheet.png";
        interactCooldown=0.75f;
        this.gameObject.tag="Squawk";
        spriteStates = AssetDatabase.LoadAllAssetsAtPath(ASSET_PATH).ToList().ConvertAll(new Converter<UnityEngine.Object, Sprite>(ObjectToSprite));
        UpdateSprite();
    }

    // Update is called once per frame
    protected override void Update()
    {
        base.Update();
        //if(interactTimer<0f){TriggerData.SetTrigger("BEE",false);}
    }
    public override void Interact()
    {
        base.Interact();
        //if not isInteracted play bee animation
        //TriggerData.SetTrigger("BEE",true);
    }
}
