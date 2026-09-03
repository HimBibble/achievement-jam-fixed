using UnityEngine;
using System.Collections.Generic;
using UnityEditor;
using System.Linq;
using System;

public class FlowerTile : Interactable
{
    string ASSET_PATH = "Assets/2D Assets/Venus_Flytrap/Venus_Flytrap_SpriteSheet.png";
    static int flowersStomped=0;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        interactCooldown=0.0f;
        this.gameObject.tag="Collision";
        spriteStates = AssetDatabase.LoadAllAssetsAtPath(ASSET_PATH).ToList().ConvertAll(new Converter<UnityEngine.Object, Sprite>(ObjectToSprite)); //populates spriteStates with all the flower sprites
        UpdateSprite();
    }

    // Update is called once per frame
    void Update()
    {

    }
    public override void Interact()
    {
        if(interactTimer<=0f)
        {
            flowersStomped++;
            TransitionSprite();
            UpdateSprite();
            if(flowersStomped==1){TriggerData.SetTrigger("TrampleFlower",true);}
            else{TriggerData.SetTrigger("Flower",false);}
            if(flowersStomped==5){TriggerData.SetTrigger("TrampleFlower5",true);}
            else{TriggerData.SetTrigger("Flower5",false);}
            if(flowersStomped==10/*whatever MAX is*/){TriggerData.SetTrigger("TrampleFlowerAll",true);}
            else{TriggerData.SetTrigger("FlowerAll",false);}
            interactTimer=1f; //cannot be interacted with again because interactTimer does not decrease
        }
    }
}
