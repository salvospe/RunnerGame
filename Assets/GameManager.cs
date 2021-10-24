using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    bool gameHasEnded = false;

    public float delay = 1f;

    public float RotationPerSecond = 1;

    public GameObject completeLevelUI;

    void Update()
    {   
        //Rotating skybox
        RenderSettings.skybox.SetFloat("_Rotation", Time.unscaledTime /*Time.time*/ * RotationPerSecond); 
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
        FindObjectOfType<AudioManager>().Stop("GameBackground");
        FindObjectOfType<LevelChanger>().FadeToLevel(SceneManager.GetActiveScene().buildIndex);
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
        FindObjectOfType<AudioManager>().Stop("GameBackground");
    }

}
