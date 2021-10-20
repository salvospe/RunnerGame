using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CountdownManager : MonoBehaviour
{
    public int countdownTime;
    public Text countdownText;
    public Text score;

    public bool isDone=false;

    private void Start()
    {
        Time.timeScale = 0;
        StartCoroutine(CountdownToStart());
    }
    IEnumerator CountdownToStart()
    {
        while(countdownTime>0)
        {
            countdownText.text = countdownTime.ToString();

            yield return new WaitForSecondsRealtime(0.8f);

            countdownTime--;
        }

        countdownText.text = "GO!";

        FindObjectOfType<AudioManager>().Play("Background");

        yield return new WaitForSecondsRealtime(0.4f);

        countdownText.gameObject.SetActive(false);
        Time.timeScale = 1;
        FindObjectOfType<PauseMenu>().CountdownDone = true;
        score.gameObject.SetActive(true);
        
    }

}