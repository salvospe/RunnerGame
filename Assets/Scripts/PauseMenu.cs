using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;
using UnityEngine.UI;

public class PauseMenu : MonoBehaviour
{
    public static bool GameIsPaused = false;

    public GameObject pauseMenuUI;

    public bool CountdownDone = false;

    public AudioMixer Master;
    public AudioMixer SoundEffects;

    public Slider MasterVolume;
    public Slider SfxVolume;

    void Start()
    {
        //getting volume values stored
        MasterVolume.value = PlayerPrefs.GetFloat("MasterVolume", 1);
        SfxVolume.value = PlayerPrefs.GetFloat("SfxVolume", 1);
    }
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.Escape) && CountdownDone)
        {
            if (!GameIsPaused)
                Pause();
        }
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
    public void Resume()
    {
        pauseMenuUI.SetActive(false);

        // back to normale rate
        Time.timeScale = 1f;

        GameIsPaused = false;
    }
    public void Pause()
    {
        pauseMenuUI.SetActive(true);

        //pause the game
        Time.timeScale = 0f;

        GameIsPaused = true;
    }

    public void LoadMenu()
    {
        Time.timeScale = 1f;
        FindObjectOfType<AudioManager>().Stop("GameBackground");
        SceneManager.LoadScene("Menu");
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
