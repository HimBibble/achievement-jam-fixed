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
        TriggerData.SetTrigger("Play",true);
        SceneManager.LoadScene("Level Blockout");
        }
        else if(SceneManager.GetActiveScene().name=="Level Blockout"){
            GameObject.Find("Canvas").GetComponent<TogglePause>().TogglePauseMenu();
            TriggerData.SetTrigger("Unpause",true);
        }
        else if(SceneManager.GetActiveScene().name=="Bad Ending" ||SceneManager.GetActiveScene().name=="Good Ending"){
            SceneManager.LoadScene("Main Menu");
        }
    }
}
