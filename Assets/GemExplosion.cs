using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GemExplosion : MonoBehaviour
{
    bool hasExploded = false;
    public float force =700f;
    public float radius = 2f;

    public Coin coinScript;

    // Start is called before the first frame update
    void Start()
    {
        coinScript = gameObject.GetComponent<Coin>();
    }

    // Update is called once per frame
    void Update()
    {
        if (!hasExploded) 
        {
            Explosion();
            hasExploded = true;

        }
        else
        {
            Invoke("afterExplosion", 1f);
            Invoke("activateMagnet", 0.5f);
            //for (int i = 0; i < 8; i++)
            //gems[i]  = gameObject this.GetChild(i);
            //coinScript.isCollectable = true;
            //Debug.Log("isCollectable");
        }
    }
    void afterExplosion()
    {
        gameObject.GetComponent<BoxCollider>().isTrigger = true;
        gameObject.GetComponent<Rigidbody>().isKinematic = true;
    }
    void activateMagnet()
    {
        coinScript.isCollectable = true;
    }
    void Explosion()
    {
        Collider[] colliders = Physics.OverlapSphere(transform.position, radius);

        foreach (Collider nearbyObject in colliders)
        {
                Rigidbody rb = nearbyObject.GetComponent<Rigidbody>();
                if ((rb != null)) //&(rb.tag == "2")
                {
                    rb.AddExplosionForce(force, transform.position, radius);
                }
        }
    }
}
