using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class WeaponSystem : MonoBehaviour
{
    [SerializeField] int bulletNum = 20;
    [SerializeField] int currentWeapon = 0;
    [SerializeField] TextMeshProUGUI bulletText;
    // Start is called before the first frame update
    private void Start()
    {
        setactiveweapon();
    }
    private void Update()
    {
        displayBullet();
    }
    public void displayBullet()
    {
        int currentbullet = bulletNum;
        bulletText.text = currentbullet.ToString();
        Debug.Log("ddddd");

    }

    public void setactiveweapon()
    {
        int weaponIndex = 0;

        foreach(Transform weapon in transform)
        {
            if(weaponIndex == currentWeapon)
            {
                weapon.gameObject.SetActive(true);
            }
            else
            {
                weapon.gameObject.SetActive(false);
            }
            weaponIndex++;
        }
    }

    public int GetBulletNum()
    {
        return bulletNum;
    }

    public void costBullet()
    {
        bulletNum--;
    }

    public void increaseBullet(int bulletAmount)
    {
        bulletNum += bulletAmount;
    }
}
