﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelLoader : MonoBehaviour
{
    public Animator transition;
    public float transitionTIme = 1f;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.B))
        {
            LoadNextLevel();
        }
    }

    public void LoadNextLevel()
    {
        StartCoroutine (LoadLevel(SceneManager.GetActiveScene().buildIndex + 1));

    }

    IEnumerator LoadLevel (int levelIndex)
    {
        //Play Animation 
        transition.SetTrigger("Start");

        //Wait 
        yield return new WaitForSeconds(transitionTIme);

        //Load Scene
        SceneManager.LoadScene(levelIndex);
    }
}
