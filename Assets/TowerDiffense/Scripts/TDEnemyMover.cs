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

    [SerializeField]
    [Range(0f, 5f)]
    private float speed = 1.1f;

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
            Vector3 startPosition = transform.position;
            Vector3 endPosition = waypoint.transform.position;
            float travelPercent = 0f;
            transform.LookAt(endPosition);
            print(": "+ waypoint.name);

            while(travelPercent < 1)
            {
                travelPercent += Time.deltaTime * speed;
                transform.position = Vector3.Lerp(startPosition, endPosition, travelPercent);
                yield return new WaitForEndOfFrame();
            }
            

            //old but gold
           // transform.position = waypoint.transform.position;
           // yield return new WaitForSeconds(timer);
        }
    }
}
