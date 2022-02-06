using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// 2022.2.6
/// </summary>

[CreateAssetMenu(menuName = "ammo's stuff")]
public class ZRAmmoSuppliesSO : ScriptableObject
{
    [SerializeField]
    int ammoToAdd = 15;

    public int GetAmmo()
    {
        return ammoToAdd;
    }
}
