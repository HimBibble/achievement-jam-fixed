using UnityEngine;
using System.Collections.Generic;
using UnityEditor;
using System.Linq;
using System;

public class ZoneTile : Interactable
{
    [SerializeField] private string zoneTrigger; //used for unlocking zone specific achievements

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        ASSET_PATH = "Assets/2D Assets/Venus_Flytrap/Venus_Flytrap_SpriteSheet.png";
        interactCooldown=0.0f;
        this.gameObject.tag="Collision";
        spriteStates = AssetDatabase.LoadAllAssetsAtPath(ASSET_PATH).ToList().ConvertAll(new Converter<UnityEngine.Object, Sprite>(ObjectToSprite));
        UpdateSprite();
    }

    // Update is called once per frame
    void Update()
    {
        if(interactTimer>0f){TriggerData.SetTrigger(zoneTrigger,false);}
    }
    public override void Interact()
    {
        if(interactTimer<=0f)
        {
            TriggerData.SetTrigger(zoneTrigger,true);
            interactTimer=1f; //will never trigger again
        }
    }
}
