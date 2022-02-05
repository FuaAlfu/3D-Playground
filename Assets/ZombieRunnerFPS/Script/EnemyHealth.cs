using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
    [SerializeField]
    private float health = 100f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void TakeDamage(float dmg)
    {
        BroadcastMessage("OnDamageTaken");
        health -= dmg;
        if(health <= 0)
        {
            Destroy(this.gameObject); //for testing..
        }
    }
}
