using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class ToggleAchievementMenu : MonoBehaviour
{
    private bool isPaused=false;
    [SerializeField] private GameObject achievementsMenu;
    [SerializeField] private GameObject background;
    [SerializeField] private GameObject content;
    [SerializeField] private GameObject achievementEntry;
    [SerializeField] private GameObject numberText;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Tab))
        {
            isPaused=!isPaused;
            if(isPaused)
            {
                Time.timeScale=0f;
                achievementsMenu.SetActive(true);
                background.SetActive(true);
                numberText.SetActive(true);
                foreach(Achievement achievement in AchievementData.lockedAchievements)
                {
                    GameObject temp = Instantiate(achievementEntry);
                    Image tempImage = temp.transform.GetChild(0).GetComponent<Image>();
                    temp.transform.SetParent(content.transform);
                    var tempColor = tempImage.color;
                    tempColor.a = 0.5f;
                    tempImage.color = tempColor;
                    TextMeshProUGUI name = temp.transform.GetChild(0).transform.GetChild(0).GetComponent<TextMeshProUGUI>();
                    TextMeshProUGUI description = temp.transform.GetChild(0).transform.GetChild(1).GetComponent<TextMeshProUGUI>();
                    name.text=achievement.achievementName;
                    description.text="???";
                    
                }
                foreach(Achievement achievement in AchievementData.unlockedAchievements)
                {
                    GameObject temp = Instantiate(achievementEntry);
                    temp.transform.SetParent(content.transform);
                    TextMeshProUGUI name = temp.transform.GetChild(0).transform.GetChild(0).GetComponent<TextMeshProUGUI>();
                    TextMeshProUGUI description = temp.transform.GetChild(0).transform.GetChild(1).GetComponent<TextMeshProUGUI>();
                    name.text=achievement.achievementName;
                    description.text=achievement.achievementDescription;
                }
                numberText.GetComponent<TextMeshProUGUI>().text="Unlocked: "+AchievementData.unlockedAchievements.Count+"/"+(AchievementData.unlockedAchievements.Count+AchievementData.lockedAchievements.Count);
            }
            else
            {
                background.SetActive(false);
                Time.timeScale=1f;
                achievementsMenu.SetActive(false);
                numberText.SetActive(false);
                ClearChildren();
            }
        }
    }
    public void ClearChildren() {
        //Debug.Log(transform.childCount);
        for (int i = 0; i < content.transform.childCount; i++) {
            Transform child = content.transform.GetChild(i);
            DestroyImmediate(child.gameObject);
        }
        //Debug.Log(transform.childCount);
    } 
}
