using UnityEngine;
using System.Collections.Generic;
using UnityEditor;
using System.Linq;
using System;

public class Flytrap : Interactable
{
    static int nomCount=0; //how many times the player has been eaten
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    protected virtual void Start()
    {
        base.Start();
        spriteIndexes = new int[] {0,2,6,3,4,5};
        ASSET_PATH = "Assets/2D Assets/Venus_Flytrap/Venus_Flytrap_SpriteSheet.png";
        interactCooldown=0.5f;
        this.gameObject.tag="Collision";
        spriteStates = AssetDatabase.LoadAllAssetsAtPath(ASSET_PATH).ToList().ConvertAll(new Converter<UnityEngine.Object, Sprite>(ObjectToSprite)); //populates flytrapSprites with all the venus flytrap sprites
        UpdateSprite();
    }

    // Update is called once per frame
    void Update()
    {
        interactTimer-=Time.deltaTime;
    }
    public override void Interact()
    {
        if(interactTimer<=0f && nomCount < 5)
        {
            nomCount++;
            player.GetComponent<PlayerDeath>().Kill();
            TransitionSprite();
            UpdateSprite();
            if(nomCount==1){TriggerData.SetTrigger("Flytrap",true);}
            else{TriggerData.SetTrigger("Flytrap",false);}
            if(nomCount==2){TriggerData.SetTrigger("Flytrap2",true);}
            else{TriggerData.SetTrigger("Flytrap2",false);}
            if(nomCount==3){TriggerData.SetTrigger("Flytrap3",true);}
            else{TriggerData.SetTrigger("Flytrap3",false);}
            if(nomCount==4){TriggerData.SetTrigger("Flytrap4",true);}
            else{TriggerData.SetTrigger("Flytrap4",false);}
            if(nomCount==5){TriggerData.SetTrigger("Flytrap5",true);}
            else{TriggerData.SetTrigger("Flytrap5",false);}
            interactTimer=interactCooldown;
        }
    }
}
