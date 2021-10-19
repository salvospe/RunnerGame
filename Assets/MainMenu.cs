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
    }

    public void Level2()
    {

        FindObjectOfType<LevelChanger>().FadeToLevel(3);
    }

    public void Level3()
    {

        FindObjectOfType<LevelChanger>().FadeToLevel(4);
    }

    public void Level4()
    {

        FindObjectOfType<LevelChanger>().FadeToLevel(5);
    }

    public void Level5()
    {

        FindObjectOfType<LevelChanger>().FadeToLevel(6);
    }

    public void Level6()
    {

        FindObjectOfType<LevelChanger>().FadeToLevel(7);
    }
    public void Level7()
    {

        FindObjectOfType<LevelChanger>().FadeToLevel(8);
    }
    public void Level8()
    {

        FindObjectOfType<LevelChanger>().FadeToLevel(9);
    }
    public void Level9()
    {

        FindObjectOfType<LevelChanger>().FadeToLevel(10);
    }
    public void Level10()
    {

        FindObjectOfType<LevelChanger>().FadeToLevel(11);
    }

    public void QuitGame ()
    {
        Application.Quit();
    }

    public void resetValues()
    {
        PlayerPrefs.DeleteKey("levelAt");
    }

}
