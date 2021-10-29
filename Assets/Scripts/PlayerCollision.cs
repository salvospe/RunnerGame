using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    public PlayerMovement PlayerMov;
    public Rigidbody rbPlayer;
    public Transform playerTransform;

    public GameObject player;
    public CubeExplosion explosionScript;

    public float jumpForce = 400f;
    public LayerMask groundMask;

    public ParticleSystem explosion;




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
            Jump();

        }
    }


    private void Jump()
    {
        // check whether we are currently grounded

        //get the bounds of the collider
        float height = GetComponent<Collider>().bounds.size.y;
        bool isGrounded = Physics.Raycast(transform.position, Vector3.down, (height / 2) + 0.1f, groundMask);

        // if we are jump

        rbPlayer.AddForce(Vector3.up * jumpForce);

        FindObjectOfType<AudioManager>().Play("Jump");
    
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "TNT")
        {
            //turning player's movement off

            //Destroy2();
            Invoke("Destroy2", 0.1f);
            Invoke("turnOff", 0.1f);
            Instantiate(explosion, other.GetComponent<Transform>().position, Quaternion.identity);
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
