
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndTrigger : MonoBehaviour
{
    public PlayerMovement PlayerMov;
    public Rigidbody rbPlayer;

    private bool levelComplete = false;

    public int nextSceneLoad;

    ScoreManager ScoreManagerScript;

    int scoreInt;

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

            updateScore();
            updateGems();

        }

    }

    void updateScoreOLD()
    {
        //converting score to integer
        int.TryParse(FindObjectOfType<Score>().score.text, out scoreInt);

        switch (SceneManager.GetActiveScene().buildIndex)
        {
            case 2:
                if (PlayerPrefs.GetInt("gems1") < FindObjectOfType<ScoreManager>().gemsCollected)
                    PlayerPrefs.SetInt("gems1", FindObjectOfType<ScoreManager>().gemsCollected);

                if (PlayerPrefs.GetInt("score1") < scoreInt)
                    PlayerPrefs.SetInt("score1", scoreInt);
                break;
            case 3:
                if (PlayerPrefs.GetInt("gems2") < FindObjectOfType<ScoreManager>().gemsCollected)
                    PlayerPrefs.SetInt("gems2", FindObjectOfType<ScoreManager>().gemsCollected);

                if (PlayerPrefs.GetInt("score2") < scoreInt)
                    PlayerPrefs.SetInt("score2", scoreInt);
                break;
            case 4:
                if (PlayerPrefs.GetInt("gems3") < FindObjectOfType<ScoreManager>().gemsCollected)
                    PlayerPrefs.SetInt("gems3", FindObjectOfType<ScoreManager>().gemsCollected);

                if (PlayerPrefs.GetInt("score3") < scoreInt)
                    PlayerPrefs.SetInt("score3", scoreInt);
                break;
            case 5:
                if (PlayerPrefs.GetInt("gems4") < FindObjectOfType<ScoreManager>().gemsCollected)
                    PlayerPrefs.SetInt("gems4", FindObjectOfType<ScoreManager>().gemsCollected);

                if (PlayerPrefs.GetInt("score4") < scoreInt)
                    PlayerPrefs.SetInt("score4", scoreInt);
                break;
            case 6:
                if (PlayerPrefs.GetInt("gems5") < FindObjectOfType<ScoreManager>().gemsCollected)
                    PlayerPrefs.SetInt("gems5", FindObjectOfType<ScoreManager>().gemsCollected);

                if (PlayerPrefs.GetInt("score5") < scoreInt)
                    PlayerPrefs.SetInt("score5", scoreInt);
                break;
            case 7:
                if (PlayerPrefs.GetInt("gems6") < FindObjectOfType<ScoreManager>().gemsCollected)
                    PlayerPrefs.SetInt("gems6", FindObjectOfType<ScoreManager>().gemsCollected);

                if (PlayerPrefs.GetInt("score6") < scoreInt)
                    PlayerPrefs.SetInt("score6", scoreInt);
                break;
            case 8:
                if (PlayerPrefs.GetInt("gems7") < FindObjectOfType<ScoreManager>().gemsCollected)
                    PlayerPrefs.SetInt("gems7", FindObjectOfType<ScoreManager>().gemsCollected);

                if (PlayerPrefs.GetInt("score7") < scoreInt)
                    PlayerPrefs.SetInt("score7", scoreInt);
                break;
            case 9:
                if (PlayerPrefs.GetInt("gems8") < FindObjectOfType<ScoreManager>().gemsCollected)
                    PlayerPrefs.SetInt("gems8", FindObjectOfType<ScoreManager>().gemsCollected);

                if (PlayerPrefs.GetInt("score8") < scoreInt)
                    PlayerPrefs.SetInt("score8", scoreInt);
                break;
            case 10:
                if (PlayerPrefs.GetInt("gems9") < FindObjectOfType<ScoreManager>().gemsCollected)
                    PlayerPrefs.SetInt("gems9", FindObjectOfType<ScoreManager>().gemsCollected);

                if (PlayerPrefs.GetInt("score9") < scoreInt)
                    PlayerPrefs.SetInt("score9", scoreInt);
                break;
            case 11:
                if (PlayerPrefs.GetInt("gems10") < FindObjectOfType<ScoreManager>().gemsCollected)
                    PlayerPrefs.SetInt("gems10", FindObjectOfType<ScoreManager>().gemsCollected);

                if (PlayerPrefs.GetInt("score10") < scoreInt)
                    PlayerPrefs.SetInt("score10", scoreInt);
                break;

        }
    }

    public void updateScore()
    {
        //converting score to integer
        int.TryParse(FindObjectOfType<Score>().score.text, out scoreInt);

        switch (SceneManager.GetActiveScene().buildIndex)
        {
            case 2:
                if (PlayerPrefs.GetInt("score1") < scoreInt)
                    PlayerPrefs.SetInt("score1", scoreInt);
                break;
            case 3:
                if (PlayerPrefs.GetInt("score2") < scoreInt)
                    PlayerPrefs.SetInt("score2", scoreInt);
                break;
            case 4:
                if (PlayerPrefs.GetInt("score3") < scoreInt)
                    PlayerPrefs.SetInt("score3", scoreInt);
                break;
            case 5:
                if (PlayerPrefs.GetInt("score4") < scoreInt)
                    PlayerPrefs.SetInt("score4", scoreInt);
                break;
            case 6:
                if (PlayerPrefs.GetInt("score5") < scoreInt)
                    PlayerPrefs.SetInt("score5", scoreInt);
                break;
            case 7:
                if (PlayerPrefs.GetInt("score6") < scoreInt)
                    PlayerPrefs.SetInt("score6", scoreInt);
                break;
            case 8:
                if (PlayerPrefs.GetInt("score7") < scoreInt)
                    PlayerPrefs.SetInt("score7", scoreInt);
                break;
            case 9:
                if (PlayerPrefs.GetInt("score8") < scoreInt)
                    PlayerPrefs.SetInt("score8", scoreInt);
                break;
            case 10:
                if (PlayerPrefs.GetInt("score9") < scoreInt)
                    PlayerPrefs.SetInt("score9", scoreInt);
                break;
            case 11:
                if (PlayerPrefs.GetInt("score10") < scoreInt)
                    PlayerPrefs.SetInt("score10", scoreInt);
                break;

        }
    }
    void updateGems()
    {
        switch (SceneManager.GetActiveScene().buildIndex)
        {
            case 2:
                if (PlayerPrefs.GetInt("gems1") < FindObjectOfType<ScoreManager>().gemsCollected)
                    PlayerPrefs.SetInt("gems1", FindObjectOfType<ScoreManager>().gemsCollected);
                break;
            case 3:
                if (PlayerPrefs.GetInt("gems2") < FindObjectOfType<ScoreManager>().gemsCollected)
                    PlayerPrefs.SetInt("gems2", FindObjectOfType<ScoreManager>().gemsCollected);
                break;
            case 4:
                if (PlayerPrefs.GetInt("gems3") < FindObjectOfType<ScoreManager>().gemsCollected)
                    PlayerPrefs.SetInt("gems3", FindObjectOfType<ScoreManager>().gemsCollected);
                break;
            case 5:
                if (PlayerPrefs.GetInt("gems4") < FindObjectOfType<ScoreManager>().gemsCollected)
                    PlayerPrefs.SetInt("gems4", FindObjectOfType<ScoreManager>().gemsCollected);
                break;
            case 6:
                if (PlayerPrefs.GetInt("gems5") < FindObjectOfType<ScoreManager>().gemsCollected)
                    PlayerPrefs.SetInt("gems5", FindObjectOfType<ScoreManager>().gemsCollected);
                break;
            case 7:
                if (PlayerPrefs.GetInt("gems6") < FindObjectOfType<ScoreManager>().gemsCollected)
                    PlayerPrefs.SetInt("gems6", FindObjectOfType<ScoreManager>().gemsCollected);
                break;
            case 8:
                if (PlayerPrefs.GetInt("gems7") < FindObjectOfType<ScoreManager>().gemsCollected)
                    PlayerPrefs.SetInt("gems7", FindObjectOfType<ScoreManager>().gemsCollected);
                break;
            case 9:
                if (PlayerPrefs.GetInt("gems8") < FindObjectOfType<ScoreManager>().gemsCollected)
                    PlayerPrefs.SetInt("gems8", FindObjectOfType<ScoreManager>().gemsCollected);
                break;
            case 10:
                if (PlayerPrefs.GetInt("gems9") < FindObjectOfType<ScoreManager>().gemsCollected)
                    PlayerPrefs.SetInt("gems9", FindObjectOfType<ScoreManager>().gemsCollected);
                break;
            case 11:
                if (PlayerPrefs.GetInt("gems10") < FindObjectOfType<ScoreManager>().gemsCollected)
                    PlayerPrefs.SetInt("gems10", FindObjectOfType<ScoreManager>().gemsCollected);
                break;

        }
    }
    void stopPlayer()
    {
        PlayerMov.enabled = false;
        rbPlayer.constraints = RigidbodyConstraints.FreezePosition;
    }
}
