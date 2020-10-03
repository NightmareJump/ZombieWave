using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Scene2 : MonoBehaviour
{
    // Start is called before the first frame update
    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {

            if (other.GetComponent<playerHealth>().oilCan>= 3)
            {
                SceneManager.LoadScene(5);
                Debug.Log("SSSSS");
            }
        }
    }
}
