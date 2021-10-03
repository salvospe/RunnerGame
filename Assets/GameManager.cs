using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    bool gameHasEnded = false;

    public float delay = 1f;

    public GameObject completeLevelUI;

    public void EndGame()
    {
        //Application.Quit();
        if (gameHasEnded == false) 
        {
            gameHasEnded = true;
            Invoke("RestartGame", delay);
        }
    }
    public void RestartGame()
    {
        FindObjectOfType<AudioManager>().Stop("Background");
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void LevelComplete()
    {
        completeLevelUI.SetActive(true);
        Invoke("stopBackground", 0.2f);
        FindObjectOfType<AudioManager>().Play("Victory");


    }
    public void stopBackground()
    {
        FindObjectOfType<AudioManager>().Stop("Background");
    }

}
