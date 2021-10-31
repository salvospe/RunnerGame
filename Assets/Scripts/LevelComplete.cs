using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelComplete : MonoBehaviour
{

    public void LoadNextLevel()
    {
        if(SceneManager.GetActiveScene().buildIndex != 9)
            FindObjectOfType<LevelChanger>().FadeToNextLevel();
        else
            FindObjectOfType<LevelChanger>().FadeToLevel(1);

    }

}
