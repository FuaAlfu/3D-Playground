using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

/// <summary>
/// 2022.2.5
/// </summary>

public class ZRSceneLoader : MonoBehaviour
{
    //void OnLevelWasLoaded(int level)
    //{
    //    if (level == 0)
    //        print("done");
    //}

    public void SceneLoader()
    {
        SceneManager.LoadScene(0);
        Time.timeScale = 1;
    }
}
