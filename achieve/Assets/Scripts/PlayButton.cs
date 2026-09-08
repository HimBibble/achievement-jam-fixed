using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayButton : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public static void OnClick()
    {
        if(SceneManager.GetActiveScene().name=="Main Menu"){
        SceneManager.LoadScene("Level Blockout");
        TriggerData.SetTrigger("Play",true);
        }
        else if(SceneManager.GetActiveScene().name=="Level Blockout"){
            GameObject.Find("Player").GetComponent<TogglePause>().TogglePauseMenu();
            TriggerData.SetTrigger("Unpause",true);
        }
        else if(SceneManager.GetActiveScene().name=="Bad Ending" ||SceneManager.GetActiveScene().name=="Good Ending"){
            SceneManager.LoadScene("Main Menu");
        }
    }
}
