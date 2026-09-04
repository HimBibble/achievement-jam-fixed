using UnityEngine;

public class CameraMovement : MonoBehaviour
{

    private float cameraX = 0;
    private float cameraY = 0;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            if (cameraY < 1)
            {
                cameraY += 0.1f;
            }
        }

        if (Input.GetKey(KeyCode.S))
        {
            if (cameraY > -1)
            {
                cameraY -= 0.1f;
            }
        }

        if (Input.GetKey(KeyCode.D))
        {
            if (cameraX < 1)
            {
                cameraX += 0.1f; // Fixed to cameraX
            }
        }

        if (Input.GetKey(KeyCode.A))
        {
            if (cameraX > -1) // Fixed to cameraX
            {
                cameraX -= 0.1f; // Fixed to cameraX
            }
        }

        transform.position = new Vector3(cameraX, cameraY, -30);
    }

}
