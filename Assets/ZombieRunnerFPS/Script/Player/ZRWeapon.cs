using System;
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

   // public InputAction playerController;
    public ShootingAction shootingAction;

    private void Awake()
    {
        shootingAction = new ShootingAction();
    }

    private void OnEnable()
    {
        //  playerController.Enable();
        shootingAction.Enable();
       // shootingAction.Weapon.Shoot.performed += Shoot();
    }

    private void OnDisable()
    {
       // shootingAction.Weapon.Shoot.performed -= Shoot();
        shootingAction.Disable();
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

       // playerController.
    }

    private void Shoot()
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
