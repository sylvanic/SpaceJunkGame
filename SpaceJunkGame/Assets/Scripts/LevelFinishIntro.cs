﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelFinishIntro : MonoBehaviour
{
    public GameObject intro;
    public GameObject text1;
    public GameObject text2;
    public GameObject text3;
    public GameObject blackout;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(ActivationRoutineCanvas());
        StartCoroutine(ActivationRoutineText());
        StartCoroutine(ActivationRoutineText2());
        StartCoroutine(ActivationRoutineText3());
        StartCoroutine(ActivationRoutineBlackout());
    }

    private IEnumerator ActivationRoutineCanvas()
    {
        yield return new WaitForSeconds(1);

        intro.SetActive(true);
    }

    private IEnumerator ActivationRoutineText()
    {
        yield return new WaitForSeconds(3);

        text1.SetActive(true);

        yield return new WaitForSeconds(4);

        text1.SetActive(false);
    }

    private IEnumerator ActivationRoutineText2()
    {
        yield return new WaitForSeconds(7);

        text2.SetActive(true);

        yield return new WaitForSeconds(4);

        text2.SetActive(false);
    }

    private IEnumerator ActivationRoutineText3()
    {
        yield return new WaitForSeconds(13);

        text3.SetActive(true);

        yield return new WaitForSeconds(5);

        text3.SetActive(false);
    }

    private IEnumerator ActivationRoutineBlackout()
    {
        yield return new WaitForSeconds(18);

        blackout.SetActive(true);
    }
}