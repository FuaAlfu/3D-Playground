using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// 2022.2.4
/// </summary>

public class TDAim : MonoBehaviour
{
    [SerializeField]
    Transform weapon;

    Transform target;

    // Start is called before the first frame update
    void Start()
    {
        target = FindObjectOfType<TDEnemyMover>().transform;
    }

    // Update is called once per frame
    void Update()
    {
        AimAt();
    }

    private void AimAt()
    {
        weapon.LookAt(target);
    }
}
