using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyAI : MonoBehaviour
{
    [SerializeField] Transform target;
    [SerializeField] float chaseRange = 5f;
    playerHealth target1;
    [SerializeField] float damage = 50f;

    NavMeshAgent navMeshAgent;
    

    float distanceToTarget = Mathf.Infinity;
    bool isProvoked = false;

    // Start is called before the first frame update
    void Start()
    {
        navMeshAgent = GetComponent<NavMeshAgent>();
        target1 = FindObjectOfType<playerHealth>();

    }

    // Update is called once per frame
    void Update()
    {
        distanceToTarget = Vector3.Distance(target.position, transform.position);
        if (isProvoked)
        {
            EngageTarget();
        }
        
        else if (distanceToTarget <= chaseRange)
        {
            isProvoked = true;

        }
        else if(distanceToTarget > chaseRange)
        {
            isProvoked = false;
        }


    }
    private void EngageTarget()
    {
        if (distanceToTarget >= navMeshAgent.stoppingDistance)
        {
            chaseTarget();
        }
        if (distanceToTarget <= navMeshAgent.stoppingDistance)
        {
            AttackTarget();
        }
    }

    void chaseTarget()
    {
        GetComponent<Animator>().SetBool("attack",false);
        GetComponent<Animator>().SetTrigger("move");
        navMeshAgent.SetDestination(target.position);
        
    }

    void AttackTarget()
    {
        GetComponent<Animator>().SetBool("attack",true);
        EnemyAttack();
    }

    void OnDrawGizmosSelected()
        {
            // Display the explosion radius when selected
            Gizmos.color = Color.red;
            
            Gizmos.DrawWireSphere(transform.position, chaseRange);
        }
    public void EnemyAttack()
    {
        target1.getHurt(damage);
    }
}
