using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// 2022.2.4
/// </summary>

public class ZRInputManager : MonoBehaviour
{
    [SerializeField]
    ZRWeapon zrWeapon;

    [SerializeField]
    ZRWeaponZoom weaponZoom;

    [SerializeField]
    ZRWeaponSwitcher weaponSwitcher;

    WeaponsControls weaponsControls;
    WeaponsControls.WeaponFiringActions fireAction;

    //catch
    Coroutine fireCoroutine;

    private void Awake()
    {
        //   playerControls = new PlayerControls();
        //  fireAction = playerControls.FireAction;
        weaponsControls = new WeaponsControls();
        fireAction = weaponsControls.WeaponFiring;

        //fireAction.[action].performed += contxt => do somthing
        fireAction.Shoot.performed += _ => zrWeapon.Shoot();
        fireAction.Zoom.performed += _ => weaponZoom.Zooming();
        fireAction.Switch.performed += _ => weaponSwitcher.SwitchWeapon();
        //fireAction.Shoot.performed += _ => StartFiring();
    }

    private void OnEnable()
    {
         weaponsControls.Enable();
    }

    //private void OnDestroy()
    //{
    //  playerControls.Disable();
    //}
    private void OnDisable()
    {
        weaponsControls.Disable();
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void StartFiring()
    {
        fireCoroutine = StartCoroutine(zrWeapon.RapidFire());
    }

    void StopFiring()
    {
        if (fireCoroutine != null)
        {
            StopCoroutine(fireCoroutine);
        }
    }
}
