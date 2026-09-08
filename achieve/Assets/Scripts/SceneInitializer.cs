using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneInitializer : MonoBehaviour
{
    private ChangeMenu changeMenu;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        if(SceneManager.GetActiveScene().name=="Main Menu"){
            changeMenu=GameObject.Find("Canvas").GetComponent<ChangeMenu>();
            changeMenu.SetMenu("Main");
        }
        if(PlayerPrefs.HasKey("Volume")){
        AudioListener.volume=PlayerPrefs.GetFloat("Volume");
        }
        else{
            PlayerPrefs.SetFloat("Volume",0.5f);
            AudioListener.volume=PlayerPrefs.GetFloat("Volume");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
