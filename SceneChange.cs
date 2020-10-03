using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChange : MonoBehaviour
{
    playerHealth num;
    // Start is called before the first frame update
    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {

            if (other.GetComponent<playerHealth>().realKeyNum >= 1)
            {
                SceneManager.LoadScene(4);
                Debug.Log("SSSSS");
            }
        }
    }
}
