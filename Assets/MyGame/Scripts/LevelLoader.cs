﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelLoader : MonoBehaviour { 
    [SerializeField] int delayInSeconds = 3;

    private int currentSceneIndex;


    public void Start()
    {
        currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
        if(currentSceneIndex == 0)
        {
            StartCoroutine(WaitForTime());
        }
        
    }

    public void LoadSplashScreen()
    {
        SceneManager.LoadScene(0);
        Debug.Log("Log Splah screen");
    }

    public void LoadStartScreen()
    {
        
    }

    IEnumerator WaitForTime()
    {
        yield return new WaitForSeconds(delayInSeconds);
        LoadNextScene();
    }

    public void LoadNextScene()
    {
        SceneManager.LoadScene(currentSceneIndex + 1);
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
