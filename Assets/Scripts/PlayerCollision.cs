using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    public PlayerMovement PlayerMov;
    public Rigidbody rbPlayer;
    public Transform playerTransform;

    public ParticleSystem deathParticles;
    void OnCollisionEnter(Collision collisionInfo)
    {
        if((collisionInfo.collider.tag=="Obstacle") || (collisionInfo.collider.tag=="Enemy") || (playerTransform.position.y < 0f))
        {
            //turning player's movement off
            Destroy();
            turnOff();

        }
    }

    void turnOff()
    {
        PlayerMov.enabled = false;
        rbPlayer.constraints = RigidbodyConstraints.FreezePosition;
        FindObjectOfType<GameManager>().EndGame();
    }

    public void Destroy()
    {
        Instantiate(deathParticles, transform.position, Quaternion.identity);
        FindObjectOfType<AudioManager>().Play("Explosion");
        gameObject.SetActive(false);

    }

}
