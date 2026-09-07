using UnityEngine;

public class Squawk : MonoBehaviour
{
    private AudioSource squawkSound;
    [SerializeField] private AudioClip SQUAWK_SOUND;
    private PlayerDeath playerDeath;
    private Animator anim;
    private float squawkTimer;
    private int squawkCount=0;//needed for achievement trigger
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        anim=transform.GetChild(0).GetComponent<Animator>();
        squawkSound = this.gameObject.GetComponent<AudioSource>();
        playerDeath=GameObject.Find("Player").GetComponent<PlayerDeath>();
    }

    // Update is called once per frame
    void Update()
    {
        squawkTimer-=Time.deltaTime;
        if(squawkTimer<0){anim.SetBool("squawk",false);}
        if (Input.GetKeyDown(KeyCode.E) && playerDeath.isDead==false && squawkTimer < 0)
        {
            squawkSound.clip = SQUAWK_SOUND;
            squawkSound.Play();
            //adding in squawk count
            squawkCount++;
            //calling interact via squawking
            GetComponent<PlayerInteract>().SquawkInteract();
            anim.SetBool("squawk",true);
            squawkTimer=0.4f;
        }
        //adding in squawk achievement triggers
        if(squawkCount==1){TriggerData.SetTrigger("Squawk",true);}
        else{TriggerData.SetTrigger("Squawk",false);}
        if(squawkCount==5){TriggerData.SetTrigger("Squawk5",true);}
        else{TriggerData.SetTrigger("Squawk5",false);}
        if(squawkCount==50){TriggerData.SetTrigger("Squawk50",true);}
        else{TriggerData.SetTrigger("Squawk50",false);}
        if(squawkTimer<-60f){TriggerData.SetTrigger("NoSquawk60",true);}
        else{TriggerData.SetTrigger("NoSquawk60",false);}
    }
}
