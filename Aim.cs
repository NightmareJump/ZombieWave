using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Aim : MonoBehaviour
{

    [SerializeField] Camera FPS;
    [SerializeField] float range = 100f;
    [SerializeField] float damage = 60f;
    [SerializeField] ParticleSystem shootFire;
    [SerializeField] GameObject hitEffect;
    [SerializeField] WeaponSystem weapon;
   // [SerializeField] TextMeshProUGUI bulletText;
   // WeaponSystem weaponBullet;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            shoot();
        }

    }


   /* public void displayBullet()
    {
        int currentbullet = weapon.GetBulletNum();
        bulletText.text = currentbullet.ToString();
        Debug.Log("", bulletText);

    }*/
    private void shoot()
    {
        if (weapon.GetBulletNum() > 0)
        {
            weapon.costBullet();
            RaycastHit hit;
            if (Physics.Raycast(FPS.transform.position, FPS.transform.forward, out hit, range))
            {
                HitEffect(hit);
                Debug.Log(" " + hit.transform.name);
                enemy target = hit.transform.GetComponent<enemy>();
                target.damage(damage);
            }
            else
            {
                return;
            }
           
        }
    }

    private void HitEffect(RaycastHit hit)
    {
        GameObject impact = Instantiate(hitEffect, hit.point, Quaternion.LookRotation(hit.normal));
        Destroy(impact, .1f);
    }
}
