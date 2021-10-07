using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinMove : MonoBehaviour
{
    Coin coinScript;

    // Start is called before the first frame update
    void Start()
    {
        coinScript = gameObject.GetComponent<Coin>();
    }

    // Update is called once per frame
    void Update()
    {
        
        transform.position = Vector3.MoveTowards(transform.position, coinScript.playerTransform.position, coinScript.speed * Time.deltaTime);
    }

    private void OnTriggerEnter(Collider other)
    {
        coinScript = gameObject.GetComponent<Coin>();
        if ((other.gameObject.tag == "PlayerBubble") & (coinScript.isCollectable))
        {
            FindObjectOfType<AudioManager>().Play("Collect");
            ScoreManager.gems++;
            Destroy(gameObject);
        }
    }

}
