using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[RequireComponent(typeof(Rigidbody2D))]
public class IsometricMovementController : MonoBehaviour
{
    [SerializeField] AnimationCurve curveY;
    private PlayerDeath playerDeath;
    //private SpriteRenderer sprite;
    //[SerializeField] private Sprite moveE;
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
        if(onGround||playerDeath.isDead)
        {
            currentPos = rb.position;
            landingPos = currentPos + movement.normalized * speed;
            landingDis = Vector2.Distance(landingPos, currentPos);
            timeElapsed = 0f;
            onGround = false;
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
            //if(horizontal > 0.1){sprite.sprite=moveE;}
            //if(horizontal < -0.1){anim.Play("MoveW");}
            //if(vertical > 0.1){anim.Play("MoveN");}
            //if(vertical < -0.1){anim.Play("MoveS");}

            movement = new Vector2(horizontal, vertical);

            if(Input.GetKeyDown("space"))
            {
                jump = true;
            }
        }

    }
}
