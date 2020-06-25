using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class VideoEnd : MonoBehaviour
{
    public float time = 55f;

    public GameObject engpic1;
    public GameObject engpic2;
    public GameObject engpic3;
    public GameObject engpic4;
    public GameObject engpic5;
    public GameObject engpic6;
    public GameObject engpic7;
    public GameObject engpic8;
    public GameObject engpic9;

    public GameObject nlpic1;
    public GameObject nlpic2;
    public GameObject nlpic3;
    public GameObject nlpic4;
    public GameObject nlpic5;
    public GameObject nlpic6;
    public GameObject nlpic7;
    public GameObject nlpic8;
    public GameObject nlpic9;

    private SceneManagement sceneManager;

    private void Awake()
    {
        sceneManager = GetComponent<SceneManagement>();
    }

    void Update()
    {
        time -= 1 * Time.deltaTime;

        if (LangSwitchBool.englishTxt)
        {
            if(time <= 55)
            {
                engpic1.SetActive(true);
            }
            if(time <= 49)
            {
                engpic1.SetActive(false);
                engpic2.SetActive(true);
            }
            if (time <= 41)
            {
                engpic2.SetActive(false);
                engpic3.SetActive(true);
            }
            if (time <= 32)
            {
                engpic3.SetActive(false);
                engpic4.SetActive(true);
            }
            if (time <= 29)
            {
                engpic4.SetActive(false);
                engpic5.SetActive(true);
            }
            if (time <= 22)
            {
                engpic5.SetActive(false);
                engpic6.SetActive(true);
            }
            if (time <= 19)
            {
                engpic6.SetActive(false);
                engpic7.SetActive(true);
            }
            if (time <= 9)
            {
                engpic7.SetActive(false);
                engpic8.SetActive(true);
            }
            if (time <= 2)
            {
                engpic8.SetActive(false);
                engpic9.SetActive(true);
            }

        }
        else
        {
            if (time <= 55)
            {
                nlpic1.SetActive(true);
            }
            if (time <= 49)
            {
                nlpic1.SetActive(false);
                nlpic2.SetActive(true);
            }
            if (time <= 41)
            {
                nlpic2.SetActive(false);
                nlpic3.SetActive(true);
            }
            if (time <= 33)
            {
                nlpic3.SetActive(false);
                nlpic4.SetActive(true);
            }
            if (time <= 29)
            {
                nlpic4.SetActive(false);
                nlpic5.SetActive(true);
            }
            if (time <= 22)
            {
                nlpic5.SetActive(false);
                nlpic6.SetActive(true);
            }
            if (time <= 20)
            {
                nlpic6.SetActive(false);
                nlpic7.SetActive(true);
            }
            if (time <= 10)
            {
                nlpic7.SetActive(false);
                nlpic8.SetActive(true);
            }
            if (time <= 3)
            {
                nlpic8.SetActive(false);
                nlpic9.SetActive(true);
            }
        }

        if (time <= 0)
        {
            engpic9.SetActive(false);
            nlpic9.SetActive(false);
            sceneManager.IntroFamiliarityYes();
        }
    }
}
