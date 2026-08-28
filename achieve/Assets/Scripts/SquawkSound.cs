using UnityEngine;

public class SquawkSound : MonoBehaviour
{
    public AudioSource squawksound;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        squawksound = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            squawksound.Play();
        }
    }
}
