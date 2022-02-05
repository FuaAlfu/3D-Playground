using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// 2022.2.5
/// </summary>

public class ZRDeathHandler : MonoBehaviour
{
    [SerializeField]
    Canvas gameOver;
    // Start is called before the first frame update
    void Start()
    {
        gameOver.enabled = false;
    }

    public void HandleDeath()
    {
        gameOver.enabled = true;
        Time.timeScale = 0;
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
    }
}
