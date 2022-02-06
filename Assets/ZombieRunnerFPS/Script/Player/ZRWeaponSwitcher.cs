using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// 2022.2.6
/// </summary>

public class ZRWeaponSwitcher : MonoBehaviour
{
    [SerializeField]
    int currentWeapon = 0;


    void Start()
    {
        SetWeaponActive();
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void SwitchWeapon()
    {
        int previousWeapon = currentWeapon;
        WChanger();
        print("Switched");

       // ProcessKeyInput();
       // ProcessScrollWheal();

        if (previousWeapon != currentWeapon)
        {
            SetWeaponActive();
        }
    }

    private void WChanger()
    {
        if (currentWeapon >= transform.childCount - 1) { currentWeapon = 0; }
            else{currentWeapon++;}
    }

    private void ProcessScrollWheal()
    {
        // if (Input.GetAxis("Mouse ScrollWeall") > 0)
        // {
        //    if(currentWeapon  >= transform.childCount - 1){currentWeapon = 0;}
        //    else{currentWeapon++;}
        // } ;
        // if (Input.GetAxis("Mouse ScrollWeall") < 0)
        // {
        //    if(currentWeapon  <= 0){currentWeapon = transform.childCount - 1;}
        //    else{currentWeapon++;}
        // } ;
    }

    private void ProcessKeyInput()
    {
        //  if (Input.GetButtonDown("Fire"){ currentWeapon = 0; }
        //  if (Input.GetKeyDowm(keyCode.Alpha1){ currentWeapon = 0; }
        //  if (Input.GetKeyDowm(keyCode.Alpha2){ currentWeapon = 1; }
        //  if (Input.GetKeyDowm(keyCode.Alpha3){ currentWeapon = 2; }

        //currentWeapon = 0;
    }

    private void SetWeaponActive()
    {
        int weaponIndex = 0;
        foreach(Transform w in transform) //w -> weapon
        {
            if(weaponIndex == currentWeapon)
            {
                w.gameObject.SetActive(true);
            }
            else 
            {
                w.gameObject.SetActive(false);
            }
            weaponIndex++;
        }
    }
}
