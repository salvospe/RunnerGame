using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    bool gameHasEnded = false;

    public float delay = 1f;

    public GameObject completeLevelUI;

    void Start()
    {
        
    }
    public void EndGame()
    {
        if (gameHasEnded == false) 
        {
            gameHasEnded = true;
            FindObjectOfType<EndTrigger>().updateScore();
            Invoke("RestartGame", delay);
        }
    }
    public void RestartGame()
    {
        FindObjectOfType<AudioManager>().Stop("Background");
        FindObjectOfType<LevelChanger>().FadeToLevel(SceneManager.GetActiveScene().buildIndex);
        //SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        ScoreManager.gems = 0;
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
