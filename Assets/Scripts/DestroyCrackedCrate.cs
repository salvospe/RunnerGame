using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyCrackedCrate : MonoBehaviour
{
    public float force = 300f;
    public float radius = 2f;
    void Update()
    {
        //gameObject.GetComponent<Rigidbody>().AddExplosionForce(force, transform.position, radius);
        if (gameObject)
            StartCoroutine(Distruct());

        //transform.GetChild(0).gameObject.GetComponent<Rigidbody>();
        
    }

    
    IEnumerator Distruct()
    {
        // Destroy shattered object
        yield return new WaitForSecondsRealtime(5f);
        //Destroy(gameObject);

    }

    
    
}
