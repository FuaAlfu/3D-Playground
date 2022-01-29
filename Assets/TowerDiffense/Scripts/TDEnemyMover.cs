using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// 2022.1.29
/// </summary>
public class TDEnemyMover : MonoBehaviour
{
    [SerializeField]
    List<TDTile> path = new List<TDTile>();

    [SerializeField]
    private float timer = 1f;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(PrintWaypointsName());
        //InvokeRepeating("Print: ", 0, 1f);
    }

    IEnumerator PrintWaypointsName()
    {
        foreach(TDTile waypoint in path)
        {
            print(": "+ waypoint.name);
            transform.position = waypoint.transform.position;
            yield return new WaitForSeconds(timer);
        }
    }
}
