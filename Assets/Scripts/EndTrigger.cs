
using UnityEngine;

public class EndTrigger : MonoBehaviour
{
    public PlayerMovement PlayerMov;
    public Rigidbody rbPlayer;

    private bool levelComplete = false;

    void OnTriggerEnter(Collider other)
    {
        if(!levelComplete)
        {
            levelComplete = true;
            FindObjectOfType<GameManager>().LevelComplete();
            //turning player's movement off
            Invoke("stopPlayer", 0.2f);
        }

    }

    void stopPlayer()
    {
        PlayerMov.enabled = false;
        rbPlayer.constraints = RigidbodyConstraints.FreezePosition;
    }
}
