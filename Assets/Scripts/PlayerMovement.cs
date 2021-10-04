using UnityEngine;

public class PlayerMovement : MonoBehaviour
{   
    //Reference to the Rididbody component called player
    public Rigidbody player;
    public Transform playerTransform;
    public Material material;

    public float forwardForce = 150f;
    public float sidewaysForce = 300f;

    // "Fixed"Update because we are dealing with physics
    void FixedUpdate()
    {
        player.AddForce(0, 0, forwardForce * Time.deltaTime);

        //if (Input.GetKey("w"))
        //    player.AddForce(0, 0, forwardForce * Time.deltaTime, ForceMode.VelocityChange);

        //if(Input.GetKey("s"))
        //    player.AddForce(0, 0, -forwardForce * Time.deltaTime, ForceMode.VelocityChange);

        if (Input.GetKey("d"))
            player.AddForce(sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);

        if (Input.GetKey("a"))
            player.AddForce(-sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);

        if (playerTransform.position.y<0f)
        {

            FindObjectOfType<GameManager>().EndGame();

        }
    }
}
