using System.Collections;
using System.Collections.Generic;
using UnityEngine;

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

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float xValue = Input.GetAxis("Horizontal") * moveSpeed * Time.deltaTime;
        float zValue = Input.GetAxis("Vertical") * moveSpeed * Time.deltaTime;
        transform.Translate(xValue, 0,zValue);
    }
}
