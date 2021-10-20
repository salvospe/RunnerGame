using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LevelSelection : MonoBehaviour
{
    public Button[] levelButtons;
    public Text[] gemsCollected;
    int levelAt;

    // Update is called once per frame
    void Update()
    {
        levelAt = PlayerPrefs.GetInt("levelAt", 2);
        for (int i = 0; i < levelButtons.Length; i++)
        {
            if (i + 2 > levelAt)
            {
                levelButtons[i].interactable = false;
            }
            switch (i)
            {
                case 0:
                    gemsCollected[i].text = PlayerPrefs.GetInt("gems1", 0).ToString("0");
                    break;
                case 1:
                    gemsCollected[i].text = PlayerPrefs.GetInt("gems2", 0).ToString("0");
                    break;
                case 2:
                    gemsCollected[i].text = PlayerPrefs.GetInt("gems3", 0).ToString("0");
                    break;
                case 3:
                    gemsCollected[i].text = PlayerPrefs.GetInt("gems4", 0).ToString("0");
                    break;
                case 4:
                    gemsCollected[i].text = PlayerPrefs.GetInt("gems5", 0).ToString("0");
                    break;
                case 5:
                    gemsCollected[i].text = PlayerPrefs.GetInt("gems6", 0).ToString("0");
                    break;
                case 6:
                    gemsCollected[i].text = PlayerPrefs.GetInt("gems7", 0).ToString("0");
                    break;
                case 7:
                    gemsCollected[i].text = PlayerPrefs.GetInt("gems8", 0).ToString("0");
                    break;
                case 8:
                    gemsCollected[i].text = PlayerPrefs.GetInt("gems9", 0).ToString("0");
                    break;
                case 9:
                    gemsCollected[i].text = PlayerPrefs.GetInt("gems10", 0).ToString("0");
                    break;

            }
        }

    }
}
