using UnityEngine;

public class PlayerJump : MonoBehaviour
{
    private Rigidbody2D rb;
    public double Velocity = 0;
    public double distance = 0;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Space) && distance < 1)
        {
            Velocity = 5;
        }
        distance += Velocity * 0.1;
        if (distance > 0)
        {
            rb.isKinematic = false;
            if (Velocity > -10)
            {
                Velocity -= 0.1;
            }
        }
        else
        {
            Velocity = 0;
            distance = 0;
            rb.isKinematic = true;
        }

    }
}
