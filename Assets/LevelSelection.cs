using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LevelSelection : MonoBehaviour
{
    public Button[] levelButtons;
    int levelAt;

    // Start is called before the first frame update
    void Start()
    {
        //levelAt = PlayerPrefs.GetInt("levelAt", 2);

    }

    // Update is called once per frame
    void Update()
    {
        levelAt = PlayerPrefs.GetInt("levelAt", 2);
        for (int i = 0; i < levelButtons.Length; i++)
            if (i + 2 > levelAt)
                levelButtons[i].interactable = false;
    }
}
