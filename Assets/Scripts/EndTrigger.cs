
using UnityEngine;

public class EndTrigger : MonoBehaviour
{
    public PlayerMovement PlayerMov;
    public Rigidbody rbPlayer;
    void OnTriggerEnter(Collider other)
    {
        FindObjectOfType<GameManager>().LevelComplete();
        //turning player's movement off
        Invoke("stopPlayer", 0.2f);
    }

    void stopPlayer()
    {
        PlayerMov.enabled = false;
        rbPlayer.constraints = RigidbodyConstraints.FreezePosition;
    }
}
