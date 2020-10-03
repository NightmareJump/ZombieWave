using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Scene3 : MonoBehaviour
{
    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {

            if (other.GetComponent<playerHealth>().fuel >= 2)
            {
                SceneManager.LoadScene(6);
                Debug.Log("SSSSS");
            }
        }
    }
}
