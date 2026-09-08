using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[RequireComponent(typeof(Rigidbody2D))]
public class IsometricMovementController : MonoBehaviour
{
    [SerializeField] AnimationCurve curveY;
    [SerializeField] private AudioClip walkSound;
    [SerializeField] private AudioClip jumpSound;
    private AudioSource audioSource;
    private PlayerDeath playerDeath;
    private static int jumpCounter=0;
    private float stepTimer=0;
    Animator anim;
    Rigidbody2D rb;
    Vector2 movement;
    Vector2 currentPos;
    Vector2 landingPos;
    float landingDis;
    float speed = 2f;
    float timeElapsed = 0f;
    private bool OnGround = true;
    public bool onGround {get {return OnGround;} set{OnGround=value;}}
    bool jump = false;

    void Start()
    {
        //sprite = transform.GetChild(0).GetComponent<SpriteRenderer>();
        anim = transform.GetChild(0).GetComponent<Animator>();
        playerDeath=GameObject.Find("Player").GetComponent<PlayerDeath>();
        rb = GetComponent<Rigidbody2D>();
        audioSource=GameObject.Find("Player").GetComponent<AudioSource>();
    }

    void Update()
    {
        InputHandler();
    }

    void FixedUpdate()
    {
        if(jump)
        {
            JumpHandler();
        }
        else
        {
            MovementHandler();
        }
    }
    void JumpHandler()
    {
        if(onGround)
        {
            currentPos = rb.position;
            landingPos = currentPos + movement.normalized * speed;
            landingDis = Vector2.Distance(landingPos, currentPos);
            timeElapsed = 0f;
            onGround = false;
            anim.SetBool("onGround",false);
            audioSource.clip=jumpSound;
            audioSource.Play();

        }
        else
        {
            timeElapsed += Time.fixedDeltaTime * speed / landingDis;
            if(timeElapsed <= 1f)
            {
                currentPos = Vector2.MoveTowards(currentPos, landingPos, Time.fixedDeltaTime * speed);
                rb.MovePosition(new Vector2(currentPos.x, currentPos.y + curveY.Evaluate(timeElapsed)));
            }
            else
            {
                jump = false;
                onGround = true;
                anim.SetBool("onGround",true);
            }
        }
    }

    void MovementHandler()
    {
        if(!playerDeath.isDead)
        {
            rb.MovePosition(rb.position + movement.normalized * speed * Time.fixedDeltaTime);
        }
    }

    void InputHandler()
    {
        stepTimer-=Time.deltaTime;
        if(!playerDeath.isDead)
        {
            float horizontal = Input.GetAxis("Horizontal");
            float vertical = Input.GetAxis("Vertical");
            if(stepTimer<0&&(horizontal>0.1f||vertical>0.1f||horizontal<-0.1f||vertical<-0.1f))
            {
                stepTimer=0.5f;
                audioSource.clip=walkSound;
                audioSource.Play();
            }
            if(Mathf.Abs(horizontal) >= Mathf.Abs(vertical))
            {
                movement = new Vector2(horizontal, 0);
                anim.SetFloat("hspeed",horizontal);
                anim.SetFloat("vspeed",0);
                if(horizontal > 0.1)
                {
                    //previousDirection="Right";
                    anim.SetInteger("previousDirection",1);
                    TriggerData.SetTrigger("MoveRight",true);
                }
                else
                {
                    TriggerData.SetTrigger("MoveRight",false);
                }
                if(horizontal < -0.1)
                {
                    //previousDirection="Left";
                    anim.SetInteger("previousDirection",2);
                    TriggerData.SetTrigger("MoveLeft",true);
                }
                else
                {
                    TriggerData.SetTrigger("MoveLeft",false);
                }
            }
            else
            {
                movement = new Vector2(0, vertical);
                anim.SetFloat("vspeed",vertical);
                anim.SetFloat("hspeed",0);
                if(vertical > 0.1)
                {
                    //previousDirection="Up";
                    anim.SetInteger("previousDirection",3);
                    TriggerData.SetTrigger("MoveUp",true);
                }
                else
                {
                    TriggerData.SetTrigger("MoveUp",false);
                }
                if(vertical < -0.1)
                {
                    //previousDirection="Down";
                    anim.SetInteger("previousDirection",4);
                    TriggerData.SetTrigger("MoveDown",true);
                }
                else
                {
                    TriggerData.SetTrigger("MoveDown",false);
                }
            }
            //movement = new Vector2(horizontal, vertical);

            if(Input.GetKeyDown("space"))
            {
                jump = true;
                jumpCounter++;
                if(jumpCounter==1){TriggerData.SetTrigger("Jump",true);}
                else{TriggerData.SetTrigger("Jump",false);}
                if(jumpCounter==5){TriggerData.SetTrigger("Jump5",true);}
                else{TriggerData.SetTrigger("Jump5",false);}
                if(jumpCounter==50){TriggerData.SetTrigger("Jump50",true);}
                else{TriggerData.SetTrigger("Jump50",false);}
            }
        }
        else
        {
            anim.SetFloat("hspeed",0);
            anim.SetFloat("vspeed",0);
        }

    }
}
