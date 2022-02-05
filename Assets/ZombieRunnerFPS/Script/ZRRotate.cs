using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// 2022.2.5
/// </summary>

public class ZRRotate : MonoBehaviour
{
    [SerializeField]
    private float turnSpeedUP, turnSpeedRight;

    // Update is called once per frame
    void Update()
    {
        TurnRight();
        TurnUp();
    }

    void TurnUp()
    {
        transform.Rotate(Vector3.up, turnSpeedUP * Time.deltaTime);
    }

    void TurnRight()
    {
        transform.Rotate(Vector3.forward, turnSpeedRight * Time.deltaTime);
    }
}
