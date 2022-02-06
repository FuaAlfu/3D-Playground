using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// 2022.2.6
/// </summary>

public class TDEnemyHealth : MonoBehaviour
{
    [SerializeField]
    private int maxHitPoint = 5;

    int currentHitPoints = 0;

    // Start is called before the first frame update
    void Start()
    {
        currentHitPoints = maxHitPoint;
    }

    //private void OnPlayerConnected(NetworkPlayer player)
    //{
        
    //}

    private void OnParticleCollision(GameObject other)
    {
        ProcessHit();
    }

    private void ProcessHit()
    {
        currentHitPoints--;
        if (currentHitPoints <= 0)
            Destroy(gameObject);
    }
}
