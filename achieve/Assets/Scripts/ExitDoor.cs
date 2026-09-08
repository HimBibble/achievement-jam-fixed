using UnityEngine;
using UnityEngine.SceneManagement;

public class ExitDoor : Interactable
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    protected override void Start()
    {
        base.Start();
        this.gameObject.tag="Collision";
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public override void Interact()
    {
        if(AchievementData.unlockedAchievements.Count>=50)
        {
            Debug.Log("a");
            SceneManager.LoadScene("Good Ending");
        }
        else
        {
            SceneManager.LoadScene("Bad Ending");
        }
    }
}
