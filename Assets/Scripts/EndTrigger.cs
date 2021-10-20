
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndTrigger : MonoBehaviour
{
    public PlayerMovement PlayerMov;
    public Rigidbody rbPlayer;

    private bool levelComplete = false;

    public int nextSceneLoad;

    ScoreManager ScoreManagerScript;

    void Start()
    {
        nextSceneLoad = SceneManager.GetActiveScene().buildIndex + 1;
    }

    void OnTriggerEnter(Collider other)
    {
        if((!levelComplete)&(other.tag=="Player"))
        {
            levelComplete = true;
            FindObjectOfType<GameManager>().LevelComplete();
            if (nextSceneLoad > PlayerPrefs.GetInt("levelAt"))
                PlayerPrefs.SetInt("levelAt", nextSceneLoad);

            //turning player's movement off
            Invoke("stopPlayer", 0.2f);

            switch (SceneManager.GetActiveScene().buildIndex)
            {
                case 2:
                    if(PlayerPrefs.GetInt("gems1")< FindObjectOfType<ScoreManager>().gemsCollected)
                        PlayerPrefs.SetInt("gems1", FindObjectOfType<ScoreManager>().gemsCollected);
                    break;
                case 3:
                    PlayerPrefs.SetInt("gems2", FindObjectOfType<ScoreManager>().gemsCollected);
                    break;
                case 4:
                    PlayerPrefs.SetInt("gems3", FindObjectOfType<ScoreManager>().gemsCollected);
                    break;
                case 5:
                    PlayerPrefs.SetInt("gems4", FindObjectOfType<ScoreManager>().gemsCollected);
                    break;
                case 6:
                    PlayerPrefs.SetInt("gems5", FindObjectOfType<ScoreManager>().gemsCollected);
                    break;
                case 7:
                    PlayerPrefs.SetInt("gems6", FindObjectOfType<ScoreManager>().gemsCollected);
                    break;
                case 8:
                    PlayerPrefs.SetInt("gems7", FindObjectOfType<ScoreManager>().gemsCollected);
                    break;
                case 9:
                    PlayerPrefs.SetInt("gems8", FindObjectOfType<ScoreManager>().gemsCollected);
                    break;
                case 10:
                    PlayerPrefs.SetInt("gems9", FindObjectOfType<ScoreManager>().gemsCollected);
                    break;
                case 11:
                    PlayerPrefs.SetInt("gems10", FindObjectOfType<ScoreManager>().gemsCollected);
                    break;

            }

        }

    }

    void stopPlayer()
    {
        PlayerMov.enabled = false;
        rbPlayer.constraints = RigidbodyConstraints.FreezePosition;
    }
}
