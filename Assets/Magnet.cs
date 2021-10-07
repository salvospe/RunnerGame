using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Magnet : MonoBehaviour
{
    public GameObject gemDetectorObj;
    // Start is called before the first frame update
    void Start()
    {
        gemDetectorObj = GameObject.FindGameObjectWithTag("GemDetector");
        gemDetectorObj.SetActive(false);
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag=="Player")
        {
            StartCoroutine(ActivateGem());
            Destroy(transform.GetChild(0).gameObject);
        }
    }

    IEnumerator ActivateGem()
    {
        gemDetectorObj.SetActive(true);
        yield return new WaitForSeconds(10f);
        gemDetectorObj.SetActive(false);
    }
}
