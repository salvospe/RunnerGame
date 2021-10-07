using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    public PlayerMovement PlayerMov;
    public Rigidbody rbPlayer;
    public Transform playerTransform;

    public GameObject player;
    public CubeExplosion explosionScript;

    public ParticleSystem deathParticles;
    void OnCollisionEnter(Collision collisionInfo)
    {
        if((collisionInfo.collider.tag=="Obstacle") || (collisionInfo.collider.tag=="Enemy") || (playerTransform.position.y < 0f))
        {
            //turning player's movement off
            Destroy2();
            turnOff();
        }
    }

    public void Destroy2()
    {
        explosionScript.enabled = true;
        FindObjectOfType<AudioManager>().Play("Explosion");
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
