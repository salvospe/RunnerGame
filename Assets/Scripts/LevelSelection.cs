using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LevelSelection : MonoBehaviour
{
    public Button[] levelButtons;
    public Text[] gemsCollected;
    public Text[] scores;
    int levelAt;

    RawImage[] logo;
    Text[] gems;

    void Start()
    {
        FindObjectOfType<AudioManager>().Play("MenuBackground");
    }

    void Update()
    {
        // unlocking levels
        levelAt = PlayerPrefs.GetInt("levelAt", 2);
        for (int i = 0; i < levelButtons.Length; i++)
        {
            if (i + 2 > levelAt)
            {
                levelButtons[i].interactable = false;
                logo=levelButtons[i].GetComponentsInChildren<RawImage>();
                gems=levelButtons[i].GetComponentsInChildren<Text>();

                foreach(RawImage logo in logo)
                {
                    Color c = logo.color;
                    c.a = 0f;
                    logo.color = c;
                }
                foreach(Text gems in gems)
                {
                    if(gems.tag!="LevelNumber")
                    {
                        Color c = gems.color;
                        c.a = 0f;
                        gems.color = c;
                    }
                }
            }

            // gems collected to screen
            switch (i)
            {
                case 0:
                    gemsCollected[i].text = PlayerPrefs.GetInt("gems1", 0).ToString("0");
                    scores[i].text = PlayerPrefs.GetInt("score1", 0).ToString("0");
                    break;
                case 1:
                    gemsCollected[i].text = PlayerPrefs.GetInt("gems2", 0).ToString("0");
                    scores[i].text = PlayerPrefs.GetInt("score2", 0).ToString("0");
                    break;
                case 2:
                    gemsCollected[i].text = PlayerPrefs.GetInt("gems3", 0).ToString("0");
                    scores[i].text = PlayerPrefs.GetInt("score3", 0).ToString("0");
                    break;
                case 3:
                    gemsCollected[i].text = PlayerPrefs.GetInt("gems4", 0).ToString("0");
                    scores[i].text = PlayerPrefs.GetInt("score4", 0).ToString("0");
                    break;
                case 4:
                    gemsCollected[i].text = PlayerPrefs.GetInt("gems5", 0).ToString("0");
                    scores[i].text = PlayerPrefs.GetInt("score5", 0).ToString("0");
                    break;
                case 5:
                    gemsCollected[i].text = PlayerPrefs.GetInt("gems6", 0).ToString("0");
                    scores[i].text = PlayerPrefs.GetInt("score6", 0).ToString("0");
                    break;
                case 6:
                    gemsCollected[i].text = PlayerPrefs.GetInt("gems7", 0).ToString("0");
                    scores[i].text = PlayerPrefs.GetInt("score7", 0).ToString("0");
                    break;
                case 7:
                    gemsCollected[i].text = PlayerPrefs.GetInt("gems8", 0).ToString("0");
                    scores[i].text = PlayerPrefs.GetInt("score8", 0).ToString("0");
                    break;
                case 8:
                    gemsCollected[i].text = PlayerPrefs.GetInt("gems9", 0).ToString("0");
                    scores[i].text = PlayerPrefs.GetInt("score9", 0).ToString("0");
                    break;
                case 9:
                    gemsCollected[i].text = PlayerPrefs.GetInt("gems10", 0).ToString("0");
                    scores[i].text = PlayerPrefs.GetInt("score10", 0).ToString("0");
                    break;

            }
        }

    }
}
