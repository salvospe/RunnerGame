using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    public PlayerMovement PlayerMov;
    public Rigidbody rbPlayer;
    void OnCollisionEnter(Collision collisionInfo)
    {
        if(collisionInfo.collider.tag=="Obstacle")
        {
            //turning player's movement off
            PlayerMov.enabled = false;
            rbPlayer.constraints = RigidbodyConstraints.FreezePosition;
            FindObjectOfType<GameManager>().EndGame();
        }

    }

}
