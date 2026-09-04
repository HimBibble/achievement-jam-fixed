using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class Death : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void Kill()
    {
        Destroy(gameObject);
        SceneManager.LoadScene("Gameover");

    }
}