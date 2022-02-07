using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// 2022.2.6
/// </summary>

public class ZRAmmoPickup : MonoBehaviour
{
    [SerializeField]
    int ammoAmount = 5;

    [SerializeField]
    ZRAmmoType ammoType;

    private void OnTriggerEnter(Collider c)
    {
        if(c.gameObject.GetComponent<ZRPlayerHealth>())
        {
            Debug.Log("Player hit....");
            FindObjectOfType<ZRAmmo>().IncreaseCurrentAmmo(ammoType, ammoAmount);
            Destroy(gameObject);
        }
    }
}
