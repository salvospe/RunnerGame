using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMenu : MonoBehaviour
{
    public void Level1()
    {
        FindObjectOfType<LevelChanger>().FadeToLevel(2);
        FindObjectOfType<AudioManager>().Stop("MenuBackground");
    }

    public void Level2()
    {

        FindObjectOfType<LevelChanger>().FadeToLevel(3);
        FindObjectOfType<AudioManager>().Stop("MenuBackground");
    }

    public void Level3()
    {

        FindObjectOfType<LevelChanger>().FadeToLevel(4);
        FindObjectOfType<AudioManager>().Stop("MenuBackground");
    }

    public void Level4()
    {

        FindObjectOfType<LevelChanger>().FadeToLevel(5);
        FindObjectOfType<AudioManager>().Stop("MenuBackground");
    }

    public void Level5()
    {

        FindObjectOfType<LevelChanger>().FadeToLevel(6);
        FindObjectOfType<AudioManager>().Stop("MenuBackground");
    }

    public void Level6()
    {

        FindObjectOfType<LevelChanger>().FadeToLevel(7);
        FindObjectOfType<AudioManager>().Stop("MenuBackground");
    }
    public void Level7()
    {

        FindObjectOfType<LevelChanger>().FadeToLevel(8);
        FindObjectOfType<AudioManager>().Stop("MenuBackground");
    }
    public void Level8()
    {

        FindObjectOfType<LevelChanger>().FadeToLevel(9);
        FindObjectOfType<AudioManager>().Stop("MenuBackground");
    }
    public void Level9()
    {

        FindObjectOfType<LevelChanger>().FadeToLevel(10);
        FindObjectOfType<AudioManager>().Stop("MenuBackground");
    }
    public void Level10()
    {

        FindObjectOfType<LevelChanger>().FadeToLevel(11);
        FindObjectOfType<AudioManager>().Stop("MenuBackground");
    }

    public void ButtonClicked()
    {
        FindObjectOfType<AudioManager>().Play("ButtonClick");
    }

    public void LevelButtonClicked()
    {
        FindObjectOfType<AudioManager>().Play("LevelSelected");
    }

    public void QuitGame ()
    {
        Application.Quit();
    }

    public void resetValues()
    {
        PlayerPrefs.DeleteAll();
    }

}
