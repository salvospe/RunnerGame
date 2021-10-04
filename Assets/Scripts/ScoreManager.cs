using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    public GameObject gemText;
    public static int gems=0;

    // Update is called once per frame


    void Update()
    {
        gemText.GetComponent<Text>().text = gems.ToString("0");
    }
}
