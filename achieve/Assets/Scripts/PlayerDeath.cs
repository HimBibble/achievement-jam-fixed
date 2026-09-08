using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class PlayerDeath : MonoBehaviour
{
    private Animator anim;
    private static AudioSource soundSource;
    private int deathCounter=0;
    [SerializeField] private AudioClip DEATH_SOUND;
    private static float respawnCooldown=2.0f;
    private static float respawnTimer=0f;
    private static PlayerInteract playerInteract;
    public bool isDead=false;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        playerInteract = GetComponent<PlayerInteract>();
        anim = transform.GetChild(0).GetComponent<Animator>();
        soundSource= this.gameObject.GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        respawnTimer-=Time.deltaTime;
        if(respawnTimer<0&&isDead)
        {
            isDead=false;
            anim.SetBool("isDead",false);
            this.gameObject.transform.position=new Vector2(0,0);
            this.gameObject.GetComponent<Rigidbody2D>().position=new Vector2(0,0);
        }
        if(respawnTimer<10&&!isDead){TriggerData.SetTrigger("Alive10",true);}
        else{TriggerData.SetTrigger("Alive10",false);}
        if(respawnTimer<30&&!isDead){TriggerData.SetTrigger("Alive30",true);}
        else{TriggerData.SetTrigger("Alive30",false);}
        if(respawnTimer<300&&!isDead){TriggerData.SetTrigger("Alive300",true);}
        else{TriggerData.SetTrigger("Alive300",false);}
        if(GetComponent<IsometricMovementController>().onGround==true&&playerInteract.inLevel==false)
        {
            Kill();
            playerInteract.inLevel=true;
            TriggerData.SetTrigger("VoidOut",true);
        }
        else{
            TriggerData.SetTrigger("VoidOut",false);
        }
    }

    public void Kill()
    {
        deathCounter++;
        soundSource.clip=DEATH_SOUND;
        soundSource.Play();
        isDead=true;
        anim.SetBool("isDead",true);
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