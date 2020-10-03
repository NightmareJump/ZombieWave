using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy : MonoBehaviour
{
    [SerializeField] float EnemyHealth = 100f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void damage(float damage)
    {
        EnemyHealth -= damage;
        if(EnemyHealth <= 0)
        {
            GetComponent<Animator>().SetTrigger("death");
            Destroy(gameObject,1);
        }
    }
}
