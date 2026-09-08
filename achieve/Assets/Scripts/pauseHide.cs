using UnityEngine;

public class pauseHide : MonoBehaviour
{
    public GameObject imageGameObject;
    public bool isVisible = false;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        imageGameObject.SetActive(isVisible);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Toggle()
    {
        isVisible = !isVisible;
        imageGameObject.SetActive(isVisible);
    }
}
