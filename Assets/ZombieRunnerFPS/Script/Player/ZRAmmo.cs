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
    Text ammoText;

    [SerializeField]
    TextMeshPro textMeshPro;

    bool isCanShoot = true;


    private void Start()
    {
        ammoText.text = ammoAmount.ToString();

        textMeshPro = GetComponent<TextMeshPro>();
    }
    public int GetCurrentAmmo()
    {
        return ammoAmount;
    }
    
    public void ReduceCurrentAmmo()
    {
        ammoAmount--;
        ammoText.text = ammoAmount.ToString();
    }
}
