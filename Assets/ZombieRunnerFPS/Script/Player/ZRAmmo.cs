using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ZRAmmo : MonoBehaviour
{
    [SerializeField]
    private int ammoAmount = 10;

    [SerializeField]
    ZRAmmoSlot[] ammoSlots;

    [System.Serializable]
    private class ZRAmmoSlot
    {
        public ZRAmmoType ammoType;
        public int ammoAmount;
    }

    [SerializeField]
    Text ammoText;

    [SerializeField]
    TextMeshPro textMeshPro;

    bool isCanShoot = true;


    private void Start()
    {
        ammoText.text = ammoAmount.ToString();

        textMeshPro = GetComponent<TextMeshPro>();
    }
    public int GetCurrentAmmo(ZRAmmoType ammoType)
    {
        // return ammoAmount;

        return GetAmmoSlot(ammoType).ammoAmount;
    }
    
    public void ReduceCurrentAmmo(ZRAmmoType ammoType)
    {
        // ammoAmount--;
        // ammoText.text = ammoAmount.ToString();

        GetAmmoSlot(ammoType).ammoAmount--;
        ammoText.text = GetAmmoSlot(ammoType).ammoAmount.ToString();
    }

    public void IncreaseCurrentAmmo(ZRAmmoType ammoType, int ammoAmount)
    {
        GetAmmoSlot(ammoType).ammoAmount += ammoAmount;
        ammoText.text = GetAmmoSlot(ammoType).ammoAmount.ToString();
    }

    private ZRAmmoSlot GetAmmoSlot(ZRAmmoType ammoType)
    {
        foreach(ZRAmmoSlot slot in ammoSlots)
        {
            if(slot.ammoType == ammoType)
            {
                return slot;
            }
        }
        return null;
    }
}
