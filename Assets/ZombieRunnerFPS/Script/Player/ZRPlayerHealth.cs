using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// 2022.2.5
/// </summary>

public class ZRPlayerHealth : MonoBehaviour
{
    [Header("Player props")]
    [Tooltip("max health point")]
    [SerializeField]
    private float healthMax = 100f;

    [Header("UI")]
    [SerializeField]
    GameObject ui;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    [ContextMenu("Health")]
    public void TakeDamage(float dmg)
    {
        healthMax -= dmg;
        print("damage: " + dmg);
        if (healthMax <= 0)
        {
            print("you died");
            //  ui.SetActive(true);
            GetComponent<ZRDeathHandler>().HandleDeath();
        }
    }
}
