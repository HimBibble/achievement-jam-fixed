using UnityEngine;

public class Squawk : MonoBehaviour
{
    private AudioSource squawkSound;
    [SerializeField] private AudioClip SQUAWK_SOUND;
    private int squawkCount=0;//needed for achievement trigger
    public bool isDead=false;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        squawkSound = this.gameObject.GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.E) && isDead==false)
        {
            squawkSound.clip = SQUAWK_SOUND;
            squawkSound.Play();
            //adding in squawk count
            squawkCount++;
            //calling interact via squawking
            this.gameObject.GetComponent<PlayerInteract>().SquawkInteract();
        }
        //adding in squawk achievement triggers
        if(squawkCount==1){TriggerData.SetTrigger("Squawk",true);}
        else{TriggerData.SetTrigger("Squawk",false);}
        if(squawkCount==5){TriggerData.SetTrigger("Squawk5",true);}
        else{TriggerData.SetTrigger("Squawk5",false);}
        if(squawkCount==50){TriggerData.SetTrigger("Squawk50",true);}
        else{TriggerData.SetTrigger("Squawk50",false);}
    }
}
