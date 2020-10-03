using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SelectLevel : MonoBehaviour
{
    // Start is called before the first frame update
    public void firstLevel()
    {
        SceneManager.LoadScene(3);
    }


    public void secondLevel()
    {
        SceneManager.LoadScene(4);
    }

    public void thirdLevel()
    {
        SceneManager.LoadScene(5);
    }
}
