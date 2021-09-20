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
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void LevelComplete()
    {
        completeLevelUI.SetActive(true);
    }
}
