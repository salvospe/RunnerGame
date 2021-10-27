using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    public PlayerMovement PlayerMov;
    public Rigidbody rbPlayer;
    public Transform playerTransform;

    public GameObject player;
    public CubeExplosion explosionScript;

    public float tempForce;

    //public ParticleSystem explosion;
    void OnCollisionEnter(Collision collisionInfo)
    {
        if((collisionInfo.collider.tag=="Obstacle") || (collisionInfo.collider.tag=="Enemy") || (playerTransform.position.y < 0f))
        {
            //turning player's movement off
            Destroy2();
            turnOff();
        }
        if (collisionInfo.collider.tag == "JumpingPad")
        {
            Debug.Log("eccolo");
            rbPlayer.AddForce(0, 1200f * Time.deltaTime, 0, ForceMode.Impulse);

            tempForce = FindObjectOfType<PlayerMovement>().forwardForce;
            FindObjectOfType<PlayerMovement>().forwardForce = 0;

            //rbPlayer.constraints = RigidbodyConstraints.FreezePositionZ;
            rbPlayer.constraints = RigidbodyConstraints.FreezePositionZ;
            rbPlayer.constraints = RigidbodyConstraints.None;

            Invoke("restoreMass", 2f);
            
        }
    }

    void restoreMass()
    {
        FindObjectOfType<PlayerMovement>().forwardForce = tempForce;
        //rbPlayer.constraints = RigidbodyConstraints.None;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "TNT")
        {
            //turning player's movement off

            //Destroy2();
            Invoke("Destroy2", 0.1f);
            Invoke("turnOff", 0.1f);
            //Instantiate(explosion, other.GetComponent<Transform>().position, Quaternion.identity);
            FindObjectOfType<AudioManager>().Play("ExplosionBox");
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

    
}
