using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class IdleQuit : MonoBehaviour
{
    public float time = 30f;

    private SceneManagement sceneManager;

    private void Awake()
    {
        sceneManager = GetComponent<SceneManagement>();
    }

    void Update()
    {
        time -= 1 * Time.deltaTime;
        if (Input.anyKey)
        {
            time = 30;
        }

        if (time <= 0)
        {
            sceneManager.ReturnToMainMenu();
        }
    }
}
