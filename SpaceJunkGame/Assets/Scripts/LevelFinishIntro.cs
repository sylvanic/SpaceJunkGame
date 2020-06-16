using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelFinishIntro : MonoBehaviour
{
    public GameObject astronaut;
    public GameObject text1;
    public GameObject text2;
    public GameObject text3;
    public GameObject text3alt;
    public GameObject MissionComplete;
    public GameObject MissionFailed;
    float time;
    bool intro1playing = true;
    bool intro2playing = true;
    bool intro3playing = true;
    bool blackoutplaying = true;
    private void Update()
    {
        time += 1 * Time.deltaTime;
        //print(time);
        intro1();
        intro2();
        intro3();
        blackout();
    }

    private void intro1()
    {
        if (intro1playing)
        {
            StartCoroutine(ActivationRoutineText());
            intro1playing = false;
        }
    }

    private void intro2()
    {
        if (intro2playing && time >= 6)
        {
            StartCoroutine(ActivationRoutineText2());
            intro2playing = false;
        }
    }

    private void intro3()
    {
        if (intro3playing && time >= 14)
        {
            StartCoroutine(ActivationRoutineText3());
            intro3playing = false;
        }
    }

    private void blackout()
    {
        if (blackoutplaying && time >= 23)
        {
            StartCoroutine(ActivationRoutineBlackout());
            blackoutplaying = false;
        }
    }

    bool firstIntro = true;
    public void SkipIntro1()
    {
        if (firstIntro)
        {
            text1.SetActive(false);
            astronaut.SetActive(false);
            firstIntro = false;
            StopAllCoroutines();
        }
    }

    bool secondIntro = true;
    public void SkipIntro2()
    {
        if (secondIntro)
        {
            text2.SetActive(false);
            astronaut.SetActive(false);
            secondIntro = false;
            StopAllCoroutines();
        }
    }

    bool thirdIntro = true;
    public void SkipIntro3()
    {
        if (thirdIntro)
        {
            text3.SetActive(false);
            text3alt.SetActive(false);
            astronaut.SetActive(false);
            thirdIntro = false;
            StopAllCoroutines();
            time = 23;
        }
    }

    private IEnumerator ActivationRoutineText()
    {
        yield return new WaitForSeconds(2);
        astronaut.SetActive(true);
        text1.SetActive(true);

        yield return new WaitForSeconds(4);
        astronaut.SetActive(false);
        text1.SetActive(false);
    }

    private IEnumerator ActivationRoutineText2()
    {
        yield return new WaitForSeconds(6);
        astronaut.SetActive(true);
        text2.SetActive(true);

        yield return new WaitForSeconds(2);
        astronaut.SetActive(false);
        text2.SetActive(false);
    }

    private IEnumerator ActivationRoutineText3()
    {
        yield return new WaitForSeconds(5);
        astronaut.SetActive(true);
        if (PlayerStats.totalScore > 10)
        {
            text3alt.SetActive(true);
            yield return new WaitForSeconds(4);
            astronaut.SetActive(false);
            text3alt.SetActive(false);
        }
        else
        {
            text3.SetActive(true);
            yield return new WaitForSeconds(4);
            astronaut.SetActive(false);
            text3.SetActive(false);
        }
    }

    private IEnumerator ActivationRoutineBlackout()
    {
        yield return new WaitForSeconds(0);

        PlayerPrefs.SetInt("ScoreLevel1", PlayerStats.totalScore);

        if (PlayerStats.totalScore > 5)
        {
            MissionComplete.SetActive(true);
        }
        else
        {
            MissionFailed.SetActive(true);
        }
    }
}
