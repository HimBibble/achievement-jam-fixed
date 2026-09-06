using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[RequireComponent(typeof(Rigidbody2D))]
public class IsometricMovementController : MonoBehaviour
{
    [SerializeField] AnimationCurve curveY;
    private PlayerDeath playerDeath;
    private string previousDirection;
    Animator anim;
    Rigidbody2D rb;
    Vector2 movement;
    Vector2 currentPos;
    Vector2 landingPos;
    float landingDis;
    float speed = 1f;
    float timeElapsed = 0f;
    bool onGround = true;
    bool jump = false;

    void Start()
    {
        //sprite = transform.GetChild(0).GetComponent<SpriteRenderer>();
        anim = transform.GetChild(0).GetComponent<Animator>();
        playerDeath=GameObject.Find("Player").GetComponent<PlayerDeath>();
        rb = GetComponent<Rigidbody2D>();
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
        rb.MovePosition(rb.position + movement.normalized * speed * Time.fixedDeltaTime);
    }

    void InputHandler()
    {
        if(!playerDeath.isDead)
        {
            float horizontal = Input.GetAxis("Horizontal");
            float vertical = Input.GetAxis("Vertical");
            if(Mathf.Abs(horizontal) >= Mathf.Abs(vertical))
            {
                movement = new Vector2(horizontal, 0);
                anim.SetFloat("hspeed",horizontal);
                anim.SetFloat("vspeed",0);
                if(horizontal > 0.1)
                {
                    previousDirection="Right";
                    anim.SetInteger("previousDirection",1);
                }
                if(horizontal < -0.1)
                {
                    previousDirection="Left";
                    anim.SetInteger("previousDirection",2);
                }
            }
            else
            {
                movement = new Vector2(0, vertical);
                anim.SetFloat("vspeed",vertical);
                anim.SetFloat("hspeed",0);
                if(vertical > 0.1)
                {
                    previousDirection="Up";
                    anim.SetInteger("previousDirection",3);
                }
                if(vertical < -0.1)
                {
                    previousDirection="Down";
                    anim.SetInteger("previousDirection",4);
                }
            }
            //movement = new Vector2(horizontal, vertical);

            if(Input.GetKeyDown("space"))
            {
                jump = true;
            }
        }
        else
        {
            anim.SetFloat("hspeed",0);
            anim.SetFloat("vspeed",0);
        }

    }
}
