using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// 2022.2.5
/// </summary>

public class ZRWeaponZoom : MonoBehaviour
{
    [SerializeField]
    Camera fpsCam;

    [SerializeField]
    private float zoomIn, zoomOut; //60f 20f

    bool zoomInToggle = false;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void Zooming()
    {
        if(zoomInToggle == false)
        {
            zoomInToggle = true;
            fpsCam.fieldOfView = zoomIn;
            Debug.Log("Zoom in");
        }
        else
        {
            zoomInToggle = false;
            fpsCam.fieldOfView = zoomOut;
            Debug.Log("Zoom out");
        }
    }
}
