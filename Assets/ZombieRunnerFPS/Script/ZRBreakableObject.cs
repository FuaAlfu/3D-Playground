using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// 2022.2.5
/// </summary>

public class ZRBreakableObject : MonoBehaviour
{
    [SerializeField]
    GameObject g;

    [SerializeField]
    Transform pos;

    [SerializeField]
    private float breakForce = 1.2f;

    private void OnTriggerEnter(Collider c)
    {
        //if (c.gameObject.GetComponent<ZRPlayerHealth>())
        //{
        //    Destroy(c.gameObject);
        //    BreakableObj();
        //}
    }

    public void BreakableObj()
    {
        GameObject frac = Instantiate(g, pos.position, Quaternion.identity);

        foreach (Rigidbody rb in frac.GetComponentsInChildren<Rigidbody>())
        {
            Vector3 force = (rb.transform.position - transform.position).normalized * breakForce;
            rb.AddForce(force);
        }
        Destroy(gameObject,0.1f);
    }
}
