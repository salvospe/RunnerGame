using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwapCamera : MonoBehaviour
{
    public GameObject frontCamera, sideCamera;

    bool isFront=true, isSide=false;
    // Start is called before the first frame update
    void Start()
    {
        //frontCamera.SetActive(true);
        //sideCamera.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        //StartCoroutine(front());
        //StartCoroutine(side());

        if (isFront)
        {
            frontCamera.SetActive(true);
            sideCamera.SetActive(false);
            Invoke("front", 10f);
        }

        if (isSide) 
        {
            frontCamera.SetActive(false);
            sideCamera.SetActive(true);
            Invoke("side", 10f);
        }
        


    }

    void front()
    {
        isFront = false;
        isSide = true;
    }

    void side()
    {
        isSide = false;
        isFront = true;
    }

    //IEnumerator front()
    //{
    //    frontCamera.SetActive(true);
    //    sideCamera.SetActive(false);
    //    yield return new WaitForSecondsRealtime(4f);
    //}

    //IEnumerator side()
    //{
    //    frontCamera.SetActive(false);
    //    sideCamera.SetActive(true);
    //    yield return new WaitForSecondsRealtime(4f);
    //}
}

