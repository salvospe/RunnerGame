using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;
public class SettingsMenu : MonoBehaviour
{
    public AudioMixer Master;
    public AudioMixer SoundEffects;

    public Dropdown resolutionDropdown;

    public Slider MasterVolume;

    public Slider SfxVolume;

    Resolution[] resolutions;



    void Start()
    {
        //getting available resolutions
        resolutions = Screen.resolutions;

        resolutionDropdown.ClearOptions();

        //converting resolutions to strings
        List<string> options = new List<string>();

        int currentResolutionIndex = 0;
        for(int i=0;i<resolutions.Length; i++)
        {
            string option = resolutions[i].width + " x " + resolutions[i].height;


            
            //if (options.Contains(option)==false)
            options.Add(option);

            if((resolutions[i].width == Screen.currentResolution.width)&& 
                (resolutions[i].height == Screen.currentResolution.height))
            {
                currentResolutionIndex = i;
            }
        }

        //add options list to resolutionDropdown
        resolutionDropdown.AddOptions(options);

        //show current resolution
        resolutionDropdown.value = currentResolutionIndex;
        resolutionDropdown.RefreshShownValue();


        //getting volume values stored
        MasterVolume.value = PlayerPrefs.GetFloat("MasterVolume", 1);
        SfxVolume.value = PlayerPrefs.GetFloat("SfxVolume", 1);

        
    }
    public void SetVolume(float volume)
    {
        Master.SetFloat("volume", Mathf.Log10(volume) * 20);
        PlayerPrefs.SetFloat("MasterVolume", volume);
    }

    public void SetVolumeSfx(float volume)
    {
        SoundEffects.SetFloat("volume", Mathf.Log10(volume) * 20);
        PlayerPrefs.SetFloat("SfxVolume", volume);
    }

    public void SetResolution(int resolutionIndex)
    {
        Resolution resolution = resolutions[resolutionIndex];
        Screen.SetResolution(resolution.width, resolution.height, Screen.fullScreen);
    }

    public void SetFullscreenbool (bool isFullscreen)
    {
        Screen.fullScreen = isFullscreen;
    }

    public void SetQuality(int qualityIndex)
    {
        QualitySettings.SetQualityLevel(qualityIndex);
    }
}
