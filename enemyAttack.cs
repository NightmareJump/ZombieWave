using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyAttack : MonoBehaviour
{
    playerHealth target;
    [SerializeField] float damage = 50f;

    // Start is called before the first frame update
    void Start()
    {
        target = FindObjectOfType<playerHealth>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void EnemyAttack()
    {
        target.getHurt(damage);
    }
}
