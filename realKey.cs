using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class realKey : MonoBehaviour
{
    playerHealth RealKey;

    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            other.GetComponent<playerHealth>().realKeyNum++;
            //RealKey.getRealKey();
            Destroy(gameObject);
        }
    }
}
