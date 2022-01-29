using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

/// <summary>
/// 2022.1.29
/// </summary>
public class ZREnemyAI : MonoBehaviour
{
    [SerializeField]
    private Transform target;

    NavMeshAgent navMeshAgent;
    // Start is called before the first frame update
    void Start()
    {
        navMeshAgent = GetComponent<NavMeshAgent>();
    }

    // Update is called once per frame
    void Update()
    {
        navMeshAgent.SetDestination(target.position);
    }

    void SetDestination()
    {
        Vector3 destance = transform.position - target.position;
    }
}
