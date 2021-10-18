
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndTrigger : MonoBehaviour
{
    public PlayerMovement PlayerMov;
    public Rigidbody rbPlayer;

    private bool levelComplete = false;

    public int nextSceneLoad;

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
            //turning player's movement off
            if (nextSceneLoad > PlayerPrefs.GetInt("levelAt"))
                PlayerPrefs.SetInt("levelAt", nextSceneLoad);
            Invoke("stopPlayer", 0.2f);

        }

    }

    void stopPlayer()
    {
        PlayerMov.enabled = false;
        rbPlayer.constraints = RigidbodyConstraints.FreezePosition;
    }
}
