using UnityEngine;

public class Settings : MonoBehaviour
{
    [SerializeField] private SeetingsHide Hide;
    [SerializeField] private SeetingsHide Hide2;
    [SerializeField] private SeetingsHide Hide3;
    [SerializeField] private SeetingsHide Hide4;
    [SerializeField] private SeetingsHide Hide5;
    [SerializeField] private SeetingsHide Hide6;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void press()
    {
        Hide.Toggle();
        Hide2.Toggle();
        Hide3.Toggle();
        Hide4.Toggle();
        Hide5.Toggle();
        Hide6.Toggle();

    }
}
