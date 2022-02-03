using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// 2022.1.28
/// </summary>

public class TDTile : MonoBehaviour
{
    /*
     WAYPOINT
     */

    [field: SerializeField]
    bool isPlaceable;

     void OnMouseOver()
    {
        Debug.Log(transform.name);
    }

    private void OnMouseDown()
    {
      //  if (Input.GetMouseButtonDown(0)) { }
      if(isPlaceable)
        Debug.Log(transform.name);
    }
}
