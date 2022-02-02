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

    NavMeshAgent navMeshAgent;
    float distanceToTarget = Mathf.Infinity;
    bool isProvoked = false;

    AudioSource audioSource;

    // Start is called before the first frame update
    void Start()
    {
        navMeshAgent = GetComponent<NavMeshAgent>();
        audioSource = GetComponent<AudioSource>();
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
    }

    private void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(transform.position, chaseRange);
    }

    private void EngageTarget()
    {
        if(distanceToTarget >= navMeshAgent.stoppingDistance)
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
        navMeshAgent.SetDestination(target.position);
        audioSource.PlayOneShot(chaseSFX);
    }

    void AttackTarget()
    {
        Debug.Log(name + "attacking" + target.name);
    }

    void SetDestination()
    {
        Vector3 destance = transform.position - target.position;
    }
}
