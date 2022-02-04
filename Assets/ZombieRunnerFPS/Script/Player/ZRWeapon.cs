using System;
using System.Collections;
using UnityEngine;
using UnityEngine.InputSystem;

/// <summary>
/// 2022.2.2
/// </summary>

public class ZRWeapon : MonoBehaviour
{
    [SerializeField]
    Camera camera;

    [SerializeField]
    float range = 100f;

    [SerializeField]
    private float healthHit = 50f;

    [SerializeField]
    private float fireRate = 5f;

    WaitForSeconds rapidFireWait;

    private void Awake()
    {
        rapidFireWait = new WaitForSeconds(1 / fireRate);
    }

    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        //if (Input.GetButtonDown("Fire1"))
        // {
        //  Shoot();
        //}
    }


   public IEnumerator RapidFire()
    {
        while(true)
        {
            Shoot();
            yield return rapidFireWait;
        }
    }

    public void Shoot()
    {
        RaycastHit hit;
        if(Physics.Raycast(camera.transform.position, camera.transform.forward, out hit, range))
        {
            Debug.Log("hit.. " + hit.transform.name);
            //TODO.. add some hit effect for visual players
            EnemyHealth target = hit.transform.GetComponent<EnemyHealth>();
            if (target == null) return;
            target.TakeDamage(healthHit);
        }
        else
        {
            return;
        }
    }
    //----------------------------------------(for testing)
    //private Action<InputAction.CallbackContext> Shoot()
    //{
    //    RaycastHit hit;
    //      Physics.Raycast(camera.transform.position, camera.transform.forward, out hit, range);
    //      Debug.Log("hit.. " + hit.transform.name);
    //}

    //private void Shoot(InputAction.CallbackContext obj)
    //{
    //    RaycastHit hit;
    //    Physics.Raycast(camera.transform.position, camera.transform.forward, out hit, range);
    //    // if(hit )
    //    // {
    //    Debug.Log("hit.. " + hit.transform.name);
    //    //}
    //}

    //private void Shoot(ShootingAction.WeaponActions obj)
    //{

    //}
}
