using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;

/// <summary>
/// 2022.1.28
/// </summary>

[ExecuteAlways]
public class CoordinateLabeler : MonoBehaviour
{
    TextMeshPro labele;
    Vector2Int coordinates = new Vector2Int();

    private void Awake()
    {
        labele = GetComponent<TextMeshPro>();
        DisplayCoordinate();
    }

    void Update()
    {
        if(Application.isPlaying)
        {
            //do something..
            DisplayCoordinate();
            UpdateObjectName();
        }
    }

    private void DisplayCoordinate()
    {
        //the script is a child to the object
        coordinates.x = Mathf.RoundToInt(transform.parent.position.x / UnityEditor.EditorSnapSettings.move.x);
        coordinates.y = Mathf.RoundToInt(transform.parent.position.z / UnityEditor.EditorSnapSettings.move.z); //we could leave it as x :: UnityEditor.EditorSnapSettings.move.x
        labele.text = coordinates.x + "," + coordinates.y;
    }

    private void UpdateObjectName()
    {
        transform.parent.name = coordinates.ToString();
    }
}
