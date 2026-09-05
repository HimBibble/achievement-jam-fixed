using UnityEngine;

public class JumpAnimation : MonoBehaviour
{
    public Transform playerTransform;
    public double Velocity = 0;
    public double distance = 0;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
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
            if (Velocity > -10)
            {
                Velocity -= 0.1;
            } 
        }
        else
        {
            Velocity = 0;
            distance = 0;
        }
        transform.position = new Vector2(playerTransform.position.x, playerTransform.position.y + (float)distance);
        if (distance < 10)
        {
            
        }
    }
}
