using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExplosionMat : MonoBehaviour
{
    public Material material;
    public GameObject Object;

    
    // Start is called before the first frame update
    void Start()
    {
        material = Object.GetComponent<Renderer>().sharedMaterial;

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
