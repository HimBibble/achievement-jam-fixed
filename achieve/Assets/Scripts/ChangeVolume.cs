using UnityEngine;

public class ChangeVolume : MonoBehaviour
{
    float currentVolume;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        currentVolume=PlayerPrefs.GetFloat("Volume");     
    }

    // Update is called once per frame
    void Update()
    {
    }
    public void IncrementVolume(float volume)
    {
        currentVolume+=volume;
        AudioListener.volume=currentVolume;
        if(currentVolume<0f){currentVolume=0f;}
        else if(currentVolume>1f){currentVolume=1f;}
        if(currentVolume==0f){
            TriggerData.SetTrigger("MuteAudio",true);
        }
        else{
            TriggerData.SetTrigger("MuteAudio",false);
        }
        PlayerPrefs.SetFloat("Volume",currentVolume);
    }
    public void MuteVolume()
    {
        currentVolume=0f;
        AudioListener.volume=currentVolume;
        PlayerPrefs.SetFloat("Volume",currentVolume);

    }
}
