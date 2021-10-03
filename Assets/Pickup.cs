using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pickup : MonoBehaviour
{
    public bool isRotating = false;
    public Vector3 rotationAngle;
    public float rotationSpeed;

    void Update()
    {
        if (isRotating)
            transform.Rotate(rotationAngle * rotationSpeed * Time.deltaTime);
    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.tag=="Player")
        {
            FindObjectOfType<AudioManager>().Play("Collect");
            Destroy(gameObject);
        }

    }
}
