using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
    [SerializeField]
    private float health = 100f;

    private bool isDead = false;

    public bool IsDead()
    {
        return isDead;
    }

    public void TakeDamage(float dmg)
    {
        BroadcastMessage("OnDamageTaken");
        health -= dmg;
        if(health <= 0)
        {
            Die();
        }
    }

    private void Die()
    {
        // Destroy(this.gameObject); //for testing..
        if (isDead) return;
        isDead = true;
        GetComponent<Animator>().SetTrigger("die");
    }
}
