using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyCrackedCrate : MonoBehaviour
{
    void Update()
    {
        if (gameObject)
            StartCoroutine(Distruct());
    }
    IEnumerator Distruct()
    {
        // Destroy shattered object
        yield return new WaitForSecondsRealtime(5f);
        Debug.Log("Destroyed");
        Destroy(gameObject);

    }
}
