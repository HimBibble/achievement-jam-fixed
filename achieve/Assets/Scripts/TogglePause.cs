using UnityEngine;

public class TogglePause : MonoBehaviour
{
    [SerializeField] private GameObject mainMenu;
    [SerializeField] private GameObject settingsMenu;
    [SerializeField] private GameObject creditsMenu;
    [SerializeField] private GameObject achievementsMenu;
    [SerializeField] private GameObject instructionsMenu;
    [SerializeField] private GameObject backButton;
    [SerializeField] private GameObject background;
    private ChangeMenu changeMenu;
    private bool isPaused=false;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        changeMenu=GetComponent<ChangeMenu>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            TogglePauseMenu();
        }
    }
    public void TogglePauseMenu()
    {
        achievementsMenu.SetActive(false);
        isPaused=!isPaused;
        if(isPaused){
            Time.timeScale=0f;
            changeMenu.SetMenu("Main");
            background.SetActive(true);
            TriggerData.SetTrigger("Unpause",false);
            TriggerData.SetTrigger("Pause",true);
        }
        else{
            Time.timeScale=1f;
            changeMenu.SetMenu("None");
            background.SetActive(false);
            TriggerData.SetTrigger("Pause",false);
            TriggerData.SetTrigger("Unpause",true);
        }
    }
}
