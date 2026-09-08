using UnityEngine;
using System.Collections.Generic;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class AchievementPopup : MonoBehaviour
{
    private float interval=0f;
    [SerializeField] private GameObject achievementEntry;
    //private GameObject achievementPopup;
    [SerializeField] private AudioSource audioSource;
    private float TIME_TO_LIVE=3f;
    //public List<Achievement> achievementsToUnlock = new List<Achievement>();
    [SerializeField] private AudioClip achievementSound;
    //public List<GameObject> achievementEntries = new List<GameObject>();
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        /*if(SceneManager.GetActiveScene().name!="Level Blockout"){*/
        //achievementPopup=GameObject.Find("Achievement Popup");
        //audioSource=GameObject.Find("Sound Source").GetComponent<AudioSource>();
        //GameObject.DontDestroyOnLoad(audioSource.gameObject);
        //GameObject.DontDestroyOnLoad(achievementPopup);
        /*}
        else{
            audioSource=GameObject.Find("Player").GetComponent<AudioSource>();
        }*/
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.childCount>0)
        {
            interval-=Time.deltaTime;
            if(interval<0f)
            {
                Destroy(transform.GetChild(0).gameObject);
                interval=TIME_TO_LIVE;
            }
        }
    }

        /*foreach(GameObject temp in achievementEntries)
        {
            Image image = temp.transform.GetComponent<Image>();
            Debug.Log(image);
            TextMeshProUGUI name = temp.transform.GetChild(0).gameObject.GetComponent<TextMeshProUGUI>();
            TextMeshProUGUI description = temp.transform.GetChild(1).gameObject.GetComponent<TextMeshProUGUI>();
            Debug.Log(name);
            Debug.Log(description);
            if(image.color==new Color(0,0,0,1f)){
                GameObject.Destroy(temp);
                achievementEntries.Remove(temp);
            }
            var tempColor = image.color;
            tempColor.a = Time.deltaTime*TIME_TO_LIVE;
            image.color = tempColor;
            name.faceColor = tempColor;
            description.faceColor = tempColor;
            temp.gameObject.transform.Translate(Vector2.up*Time.deltaTime);
        }
    }*/
    public void UnlockAchievement(Achievement achievement)
    {
        audioSource.clip=achievementSound;
        audioSource.Play();
        GameObject temp=Instantiate(achievementEntry,this.gameObject.transform);
        //temp.transform.SetParent(this.gameObject.transform);
        //temp.transform.position=new Vector2(399.9806f,-299.6989f);
        //achievementEntries.Add(temp.transform.GetChild(0).gameObject);
        TextMeshProUGUI name = temp.transform.GetChild(0).transform.GetChild(0).GetComponent<TextMeshProUGUI>();
        TextMeshProUGUI description = temp.transform.GetChild(0).transform.GetChild(1).GetComponent<TextMeshProUGUI>();
        name.text=achievement.achievementName;
        description.text=achievement.achievementDescription;
    }
}
