using UnityEngine;

public class PlayerAnimation : MonoBehaviour
{
    private Animator anim;

    public string[] IdleDirections = { "IdleN", "IdleW", "IdleS", "IdleE"};
    public string[] MoveDirections = { "MoveN", "MoveW", "MoveS", "MoveE" };

    int lastDirection;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        anim = GetComponent<Animator>();

        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SetDirection (Vector2 _direction)
    {
        string [] directionArray = null;
        if (_direction.sqrMagnitude < 0.01f)
        {
            directionArray = IdleDirections;
        }
        else 
        { 
            directionArray = MoveDirections;

            lastDirection = DirectionToIndex(_direction);
        }

        anim.Play(directionArray[lastDirection]);
    }

    private int DirectionToIndex(Vector2 _direction)
    {
        Vector2 norDir = _direction.normalized;

        float step = 360 / 4;

        float offset = step / 2;

        float angle = Vector2.SignedAngle(Vector2.up, norDir);

        angle += offset;
        if(angle < 0)
        {
            angle += 360;
        }

        float stepCount = angle / step;
        return Mathf.FloorToInt(stepCount);
    }
}
