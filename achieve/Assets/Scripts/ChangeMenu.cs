using UnityEngine;

public class ChangeMenu : MonoBehaviour
{
    [SerializeField] private GameObject mainMenu;
    [SerializeField] private GameObject settingsMenu;
    [SerializeField] private GameObject creditsMenu;
    [SerializeField] private GameObject achievementsMenu;
    [SerializeField] private GameObject instructionsMenu;
    [SerializeField] private GameObject backButton;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        /*mainMenu=GameObject.Find("Main Menu");
        settingsMenu=GameObject.Find("Settings Menu");
        creditsMenu=GameObject.Find("Credits Menu");
        backButton=GameObject.Find("Back Button");*/
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void SetMenu(string menu)
    {
        mainMenu.SetActive(false);
        settingsMenu.SetActive(false);
        creditsMenu.SetActive(false);
        instructionsMenu.SetActive(false);
        backButton.SetActive(false);
        if(menu=="Main"){
            mainMenu.SetActive(true);
        }
        else if (menu=="Settings")
        {
            settingsMenu.SetActive(true);
            backButton.SetActive(true);
        }
        else if (menu=="Credits")
        {
            creditsMenu.SetActive(true);
            backButton.SetActive(true);
        }
        else if (menu=="Instructions")
        {
            instructionsMenu.SetActive(true);
            backButton.SetActive(true);
        }

    }
}
