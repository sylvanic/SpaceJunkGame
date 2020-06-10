using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class IdleQuit : MonoBehaviour
{
    public float time = 30f;

    void Update()
    {
        time -= 1 * Time.deltaTime;
        if (Input.anyKey)
        {
            time = 30;
        }

        if (time <= 0)
        {
            SceneManager.LoadScene("NEW_Menu");
        }
    }
}
