using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    public double Velocity = 0;
    public double distance = 0;
    private Rigidbody2D rb;
    private float moveh, movev;
    [SerializeField] private float speed = 1.0f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        moveh = Input.GetAxis("Horizontal") * speed;
        movev = Input.GetAxis("Vertical") * speed;
        //christian wuz here, just checkin for achievement triggers
        if(moveh>0){TriggerData.SetTrigger("MoveRight",true);}
        else{TriggerData.SetTrigger("MoveRight",false);}
        if(moveh<0){TriggerData.SetTrigger("MoveLeft",true);}
        else{TriggerData.SetTrigger("MoveLeft",false);}
        if(movev>0){TriggerData.SetTrigger("MoveUp",true);}
        else{TriggerData.SetTrigger("MoveUp",false);}
        if(movev<0){TriggerData.SetTrigger("MoveDown",true);}
        else{TriggerData.SetTrigger("MoveDown",false);}
        //end christian code
        rb.linearVelocity = new Vector2(moveh, movev);

        Vector2 direction = new Vector2(moveh, movev);
        FindAnyObjectByType<PlayerAnimation>().SetDirection(direction);
        // ^you were using a deprecated function but this one seems to do the same thing so I went ahead and changed it

        if (Input.GetKey(KeyCode.Space) && distance < 1)
        {
            Velocity = 5;
        }
        distance += Velocity * 0.1;
        if (distance > 0)
        {
            rb.isKinematic = true;
            if (Velocity > -10)
            {
                Velocity -= 0.2;
            }
        }
        else
        {
            Velocity = 0;
            distance = 0;
            rb.isKinematic = false;
        }
    }
}
