using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerHealth : MonoBehaviour
{
    [SerializeField] float PlayerHealth = 100f;
    public int fakeKeyNum = 0;
    public int realKeyNum = 0;
    public int oilCan = 0;
    public int fuel = 0;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void getFakeKey()
    {
        fakeKeyNum++;

    }

    public void getRealKey()
    {
        realKeyNum++;
    }

    public void getHurt(float damage)
    {
        PlayerHealth -= damage;
        if(PlayerHealth <= 0)
        {
            GetComponent<Death>().death();
        }
    }
}
