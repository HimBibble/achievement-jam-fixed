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
        rb.linearVelocity = new Vector2(moveh, movev);

        Vector2 direction = new Vector2(moveh, movev);
        FindObjectOfType<PlayerAnimation>().SetDirection(direction);
    }
}
