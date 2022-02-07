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
    private ZRAmmo ammoSlot;

    [SerializeField]
    private ParticleSystem particle;

    [SerializeField]
    private GameObject hitParticle;

    [SerializeField]
    private Transform gunBox;

    [SerializeField]
    ZRAmmoType ammoType;

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
        if(ammoSlot.GetCurrentAmmo(ammoType) > 0)
        {
            //particle
            PlayParticle();
            ProcessRaycast();
            ProcessRaycastAgain();
            ammoSlot.ReduceCurrentAmmo(ammoType);
        }
    }

    private void PlayParticle()
    {
        particle.Play();
    }

    private void ProcessRaycast()
    {
        RaycastHit hit;
        if (Physics.Raycast(camera.transform.position, camera.transform.forward, out hit, range))
        {
            Debug.Log("hit.. " + hit.transform.name);
            //TODO.. add some hit effect for visual players
            CreateHitImpact(hit);
           // ZRBreakableObject obj = hit.transform.GetComponent<ZRBreakableObject>();
            //if (obj == null) return;
            //obj.BreakableObj();

            EnemyHealth target = hit.transform.GetComponent<EnemyHealth>();
            if (target == null) return;
            target.TakeDamage(healthHit);
        }
        else
        {
            return;
        }
    }

    private void ProcessRaycastAgain()
    {
        RaycastHit hit;
        if (Physics.Raycast(camera.transform.position, camera.transform.forward, out hit, range))
        {
            Debug.Log("hit.. " + hit.transform.name);
            //TODO.. add some hit effect for visual players
            CreateHitImpact(hit);
            ZRBreakableObject obj = hit.transform.GetComponent<ZRBreakableObject>();
            if (obj == null) return;
            obj.BreakableObj();
        }
        else
        {
            return;
        }
    }

    private void CreateHitImpact(RaycastHit hit)
    {
        EnemyHealth target = hit.transform.GetComponent<EnemyHealth>();
        // if (hit.Equals(target))
        //{
            GameObject impact = Instantiate(hitParticle, hit.point, Quaternion.LookRotation(hit.normal));
            Destroy(impact, 1.2f);
        //}
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
