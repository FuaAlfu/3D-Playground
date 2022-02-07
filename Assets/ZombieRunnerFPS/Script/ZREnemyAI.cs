using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

/// <summary>
/// 2022.1.29
/// </summary>
public class ZREnemyAI : MonoBehaviour
{
    //--------------------(Audio)
    [SerializeField]
    AudioClip chaseSFX;
    //--------------------
    [SerializeField]
    private Transform target;

    [SerializeField]
    private float chaseRange = 5f;

    [SerializeField]
    private float turnSpeed = 5f;

    NavMeshAgent navMeshAgent;
    float distanceToTarget = Mathf.Infinity;
    bool isProvoked = false;

    AudioSource audioSource;
    EnemyHealth enemyHealth;

    // Start is called before the first frame update
    void Start()
    {
        navMeshAgent = GetComponent<NavMeshAgent>();
        audioSource = GetComponent<AudioSource>();

        enemyHealth = GetComponent<EnemyHealth>();
    }

    // Update is called once per frame
    void Update()
    {
        if(enemyHealth.IsDead())
        {
            enabled = false;
            navMeshAgent.enabled = false;
        }
        distanceToTarget = Vector3.Distance(target.position, transform.position);
        if (isProvoked)
        {
            EngageTarget();
        }

        else if (distanceToTarget <= chaseRange)
        {
            isProvoked = true;
        }   
    }

    private void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(transform.position, chaseRange);
    }

    private void EngageTarget()
    {
        FaceTarget();
        if (distanceToTarget >= navMeshAgent.stoppingDistance)
        {
            ChaseTarget();
        }

        else if (distanceToTarget <= navMeshAgent.stoppingDistance)
        {
            AttackTarget();
        }
    }

    void ChaseTarget()
    {
        GetComponent<Animator>().SetBool("attack", false);
        GetComponent<Animator>().SetTrigger("move");
        navMeshAgent.SetDestination(target.position);
        //audioSource.PlayOneShot(chaseSFX);
    }

    void AttackTarget()
    {
        GetComponent<Animator>().SetBool("attack", true);
      //  Debug.Log(name + "attacking" + target.name);
    }

    public void OnDamageTaken()
    {
        isProvoked = true;
    }

    private void FaceTarget()
    {
        Vector3 direction = (target.position - transform.position).normalized;
        Quaternion lookRotation = Quaternion.LookRotation(new Vector3(direction.x, 0, direction.z));
        transform.rotation = Quaternion.Slerp(transform.rotation, lookRotation, Time.deltaTime * turnSpeed);
    }

    void SetDestination()
    {
        Vector3 destance = transform.position - target.position;
    }
}
