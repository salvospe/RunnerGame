using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeExplosion : MonoBehaviour
{
    public int cubesPerAxis = 8;
    public float delay = 1f;
    public float force = 300f;
    public float radius = 2f;

    PlayerCollision PlayerCollisionScript;

    // Start is called before the first frame update
    void Start()
    {
        PlayerCollisionScript= gameObject.GetComponent<PlayerCollision>();
        Invoke("Main", delay);
    }

    void Main()
    {
        // Three nested loops to create the small cubes
        for (int x = 0; x < cubesPerAxis; x++)
            for (int y = 0; y < cubesPerAxis; y++)
                for (int z = 0; z < cubesPerAxis; z++)
                    CreateCube(new Vector3(x, y, z));

        // Destroy the original big cube
        gameObject.SetActive(false);
    }

    void CreateCube(Vector3 coordinates)
    {
        // Create the cube
        GameObject cube = GameObject.CreatePrimitive(PrimitiveType.Cube);

        // Turn off mesh renderer
        MeshRenderer MeshComponent = cube.GetComponent<MeshRenderer>();
        //MeshComponent.enabled = false;

        // Set material to match the original cube
        Renderer rd = cube.GetComponent<Renderer>();
        rd.material = GetComponent<Renderer>().material;

        // Set scale to be a fraction of the original cube
        Vector3 offset = new Vector3(0.2f, 0.2f, 0.2f);
        cube.transform.localScale = (transform.localScale - offset) / cubesPerAxis;
        //cube.transform.localScale = transform.localScale / cubesPerAxis;

        // Set the position
        Vector3 offset2 = new Vector3(0, 0.2f, 0);
        Vector3 firstCube = (transform.position+offset2) - transform.localScale / 2 + cube.transform.localScale / 2;
        cube.transform.position = firstCube + Vector3.Scale(coordinates, cube.transform.localScale);

        // Create the explosion
        Rigidbody rb = cube.AddComponent<Rigidbody>();
        rb.AddExplosionForce(force, transform.position, radius);

        // Turn on mesh renderer
        //MeshComponent.enabled = true;


    }

    
}
