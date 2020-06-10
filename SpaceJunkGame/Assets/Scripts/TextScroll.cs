using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TextScroll : MonoBehaviour
{
    float cont = 0;
    float scroll;

    public GameObject IntroText;
    private SoundManager soundManager;

    private void Awake()
    {
        IntroText = GameObject.Find("Intro Text");
    }
    void Update()
    {
    
        if (Input.GetKey(KeyCode.Mouse0) && (IntroText.activeInHierarchy == true))
        {
            scroll = 50;
            transform.Translate(0, scroll * Time.deltaTime, 0);
            cont += scroll * Time.deltaTime;

        }
        else
        {
            scroll = 4;
            transform.Translate(0, scroll * Time.deltaTime, 0);
            cont += scroll * Time.deltaTime;
        }

        if (cont >= 300)
        {
            SceneManager.LoadScene("Tutorial");  ///Intro done, load tutorial

        }

    }
}
