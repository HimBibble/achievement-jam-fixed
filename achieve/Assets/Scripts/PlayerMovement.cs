using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
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
        if(moveh<0){TriggerData.SetTrigger("MoveLeft",true);}
        if(movev>0){TriggerData.SetTrigger("MoveUp",true);}
        if(movev<0){TriggerData.SetTrigger("MoveDown",true);}
        //end christian code
        rb.linearVelocity = new Vector2(moveh, movev);

        Vector2 direction = new Vector2(moveh, movev);
        FindObjectOfType<PlayerAnimation>().SetDirection(direction);
    }
}
