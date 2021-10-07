using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    public bool isRotating = false;
    public bool isFloating = false;

    public Vector3 rotationAngle;
    public float rotationSpeed;

    public Transform playerTransform;
    public float speed = 17f;

    public bool isCollectable=true;
    CoinMove coinMoveScript;
    //Coin coinScript;

    // Start is called before the first frame update
    void Start()
    {
        playerTransform = GameObject.FindGameObjectWithTag("Player").transform;
        coinMoveScript = gameObject.GetComponent<CoinMove>();
    }

    void Update()
    {
        if (isRotating)
            transform.Rotate(rotationAngle * rotationSpeed * Time.deltaTime);
        if ((gameObject.tag == "2")&(isCollectable))
            coinMoveScript.enabled = true;

    }

    private void OnTriggerEnter(Collider other)
    {


        if ((other.gameObject.tag=="GemDetector")&(isCollectable))
        {
            coinMoveScript.enabled = true;

            //if (gameObject.tag == "2")
            //    gameObject.GetComponent<BoxCollider>().isTrigger = true;
        }

    }
    
}
