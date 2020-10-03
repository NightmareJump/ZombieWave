using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pickupFeul : MonoBehaviour
{
    // Start is called before the first frame update
    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            other.GetComponent<playerHealth>().fuel++;
            //RealKey.getRealKey();
            Destroy(gameObject);
        }
    }
}
