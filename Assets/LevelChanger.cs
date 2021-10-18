using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelChanger : MonoBehaviour
{
    public Animator animator;

    private int levelToLoad;

    public bool isFading=false;
    public bool FadeOutComplete = false; 
    // Update is called once per frame
    void Start()
    {
        if(SceneManager.GetActiveScene().buildIndex==0)
            StartCoroutine(fade());
    }

    void Update()
    {
        if (isFading)
            FadeToNextLevel();
    }

    IEnumerator fade()
    {

        yield return new WaitForSecondsRealtime(5f);
        isFading = true;


    }
    public void FadeToNextLevel()
    {
        FadeToLevel(SceneManager.GetActiveScene().buildIndex + 1);
    }    
    public void FadeToLevel(int levelIndex)
    {
        levelToLoad = levelIndex;
        animator.SetTrigger("FadeOutTrigger");
    }

    public void OnFadeComplete()
    {
        SceneManager.LoadScene(levelToLoad);
    }
}
