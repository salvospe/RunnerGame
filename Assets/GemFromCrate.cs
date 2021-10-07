using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GemFromCrate : MonoBehaviour
{
    public float t;
    void Start()
    {
        for (int i = 0; i < 8; i++)
        {
            transform.GetChild(i+16).gameObject.transform.position = Vector3.Lerp(transform.position, transform.GetChild(i).gameObject.transform.position, t);
        }
        for (int i = 0; i < 8; i++)
        {
            transform.position = Vector3.Lerp(transform.position, transform.GetChild(i + 8).gameObject.transform.position, t);
        }
    }

    // Update is called once per frame
    void FixedUpdate()
    {

    }
}
