﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Again : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void againGame()
    {
        SceneManager.LoadScene(3);
        //Time.timeScale = 1;
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
