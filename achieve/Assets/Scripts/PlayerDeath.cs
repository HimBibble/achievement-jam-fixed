using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class PlayerDeath : MonoBehaviour
{
    //static string ANIM_PATH=
    private static AudioSource soundSource;
    private int deathCounter=0;
    [SerializeField] private AudioClip DEATH_SOUND;
    private static float respawnCooldown=2.0f;
    private static float respawnTimer=0f;
    static PlayerMovement playerMovement;
    //static PlayerJump playerJump;
    static Squawk squawk;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        soundSource= this.gameObject.GetComponent<AudioSource>();
        playerMovement = this.gameObject.GetComponent<PlayerMovement>();
        //playerJump = this.gameObject.GetComponent<PlayerJump>();
        squawk = this.gameObject.GetComponent<Squawk>();
    }

    // Update is called once per frame
    void Update()
    {
        respawnTimer-=Time.deltaTime;
        if(respawnTimer<0)
        {
            //playerJump.isDead=false;
            squawk.isDead=false;
            playerMovement.isDead=false;
        }
    }

    public void Kill()
    {
        deathCounter++;
        //play death animation
        soundSource.clip=DEATH_SOUND;
        soundSource.Play();
        //playerJump.isDead=true;
        squawk.isDead=true;
        playerMovement.isDead=true;
        if(respawnTimer>-5f){TriggerData.SetTrigger("DieIn5s",true);}
        else{TriggerData.SetTrigger("DieIn5s",false);}
        if(deathCounter==1){TriggerData.SetTrigger("Die",true);}
        else{TriggerData.SetTrigger("Die",false);}
        if(deathCounter==5){TriggerData.SetTrigger("Die5",true);}
        else{TriggerData.SetTrigger("Die5",false);}
        if(deathCounter==42){TriggerData.SetTrigger("Die42",true);}
        else{TriggerData.SetTrigger("Die42",false);}
        respawnTimer=respawnCooldown;


    }
}