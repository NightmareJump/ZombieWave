using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bulletPickup : MonoBehaviour
{
    [SerializeField] int bulletAmount = 30;

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Player")
        {
            FindObjectOfType<WeaponSystem>().increaseBullet(bulletAmount);
            Destroy(gameObject);
        }
    }
}
