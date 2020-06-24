using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class VideoEnd : MonoBehaviour
{
    public float time = 55f;

    private SceneManagement sceneManager;

    private void Awake()
    {
        sceneManager = GetComponent<SceneManagement>();
    }

    void Update()
    {
        time -= 1 * Time.deltaTime;

        if (time <= 0)
        {
            sceneManager.IntroFamiliarityYes();
        }
    }
}
