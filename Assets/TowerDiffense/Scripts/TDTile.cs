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

    [SerializeField]
    private GameObject prefabe;

     void OnMouseOver()
    {
        Debug.Log(transform.name);
    }

     void OnMouseDown()
    {
      //  if (Input.GetMouseButtonDown(0)) { }
      if(isPlaceable)
        {
            Debug.Log(transform.name);
            Instantiate(prefabe, transform.position, Quaternion.identity);
            isPlaceable = false;  //prevent add more tower on a previous tower..
        }
    }
}
