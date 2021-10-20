using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    public GameObject gemText;
    public static int gems=0;
    public int gemsCollected=0;

    public int totalGems;
    int totalCrates;

    // Update is called once per frame

    void Start()
    {
        totalGems = GameObject.FindGameObjectsWithTag("Gem").Length;

        totalCrates = (GameObject.FindGameObjectsWithTag("Crate").Length)*8;
        gems = 0;
    }


    void Update()
    {
        gemText.GetComponent<Text>().text = gems.ToString("0") + "/" + (totalGems+totalCrates);
        gemsCollected = gems;
    }
}
