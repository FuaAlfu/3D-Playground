using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

/// <summary>
/// 2022.1.27
/// </summary>

public class OBPlayer : MonoBehaviour
{
    [Header("props")]
    [SerializeField]
    private float xValue, yValue,zValue = 0.01f;

    [SerializeField]
    private float moveSpeed = 2.2f;

    public InputAction playerController;

    Vector3 moveDirection = Vector3.zero;
    Rigidbody rb;


    private void OnEnable()
    {
        playerController.Enable();
    }

    private void OnDisable()
    {
        playerController.Disable();  
    }
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        /*
         # old input system
        float xValue = Input.GetAxis("Horizontal") * moveSpeed * Time.deltaTime;
        float zValue = Input.GetAxis("Vertical") * moveSpeed * Time.deltaTime;
        transform.Translate(xValue, 0,zValue);
        */

        moveDirection = playerController.ReadValue<Vector3>();
    }

    private void FixedUpdate()
    {
        rb.velocity = new Vector3(moveDirection.x * moveSpeed, moveDirection.y * 0, moveDirection.z * moveSpeed);
    }
}
