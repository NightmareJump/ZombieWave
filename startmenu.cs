using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class startmenu : MonoBehaviour
{
    public void StartGame()
    {
        SceneManager.LoadScene(3);
    }

    public void QuitGame()
    {
        Application.Quit();
    }

    public void aboutGame()
    {
        SceneManager.LoadScene(1);
    }

    public void level()
    {
        SceneManager.LoadScene(2);
    }
}
