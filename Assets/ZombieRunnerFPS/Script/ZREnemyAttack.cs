using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// 2022.2.5
/// </summary>

public class ZREnemyAttack : MonoBehaviour
{
    [SerializeField]
    float damage = 40f;

    ZRPlayerHealth target;

    // Start is called before the first frame update
    void Start()
    {
        target = FindObjectOfType<ZRPlayerHealth>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void AttackHitEvent()
    {
        if (target == null) return;
        //Debug.Log("hit hit hit: "+ damage);
        //target.GetComponent<ZRPlayerHealth>().TakeDamage(damage); :: if you will
        //FindObjectOfType<ZRPlayerHealth>().TakeDamage(damage);
        target.TakeDamage(damage);
    }
}
