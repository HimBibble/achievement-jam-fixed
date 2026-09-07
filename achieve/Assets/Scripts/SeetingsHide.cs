using UnityEngine;

public class SeetingsHide : MonoBehaviour
{
    public GameObject imageGameObject;
    public bool Setting = true;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        imageGameObject.SetActive(Setting);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Toggle()
    {
        Setting = !Setting;
        imageGameObject.SetActive(Setting);
    }
}
