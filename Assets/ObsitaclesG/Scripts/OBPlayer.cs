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

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(xValue, yValue,zValue);
    }
}
