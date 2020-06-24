using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelFinishIntro2 : MonoBehaviour
{
    public GameObject astronaut;
    public GameObject text1;
    public GameObject text2;
    public GameObject text3;
    public GameObject text3alt;
    public GameObject MissionComplete;
    public GameObject MissionFailed;
    float time;
    bool intro1play = true;
    bool intro2play = true;
    bool intro3play = true;
    bool blackoutplay = true;

    private void Update()
    {
        time += 1 * Time.deltaTime;
        Intro1();
        Intro2();
        Intro3();
        Blackout();
    }

    public void Intro1()
    {
        if (intro1play)
        {
            StartCoroutine(ActivationRoutineText());
            intro1play = false;
        }
    }

    public void Intro2()
    {
        if (intro2play && time >= 8.5)
        {
            StartCoroutine(ActivationRoutineText2());
            intro2play = false;
        }
    }

    public void Intro3()
    {
        if (intro3play && time >= 12.5)
        {
            StartCoroutine(ActivationRoutineText3());
            intro3play = false;
        }
    }

    public void Blackout()
    {
        if (blackoutplay && time >= 18)
        {
            StartCoroutine(ActivationRoutineBlackout());
            blackoutplay = false;
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
            time = 18;
        }
    }

    public void SkipCutscene()
    {
        intro1play = false;
        intro2play = false;
        intro3play = false;
        blackoutplay = false;
        StopAllCoroutines();
        StartCoroutine(ActivationRoutineBlackout());
    }

    private IEnumerator ActivationRoutineText()
    {
        astronaut.SetActive(true);
        text1.SetActive(true);

        yield return new WaitForSeconds(4);
        astronaut.SetActive(false);
        text1.SetActive(false);
    }

    private IEnumerator ActivationRoutineText2()
    {
        text2.SetActive(true);
        yield return new WaitForSeconds(4);
        text2.SetActive(false);
    }

    private IEnumerator ActivationRoutineText3()
    {
        astronaut.SetActive(true);
        if (PlayerStats.totalScore > 50)
        {
            
            text3.SetActive(true);

            yield return new WaitForSeconds(5);
            astronaut.SetActive(false);
            text3.SetActive(false);
        }
        
        else
        {
            text3alt.SetActive(true);
            yield return new WaitForSeconds(5);
            astronaut.SetActive(false);
            text3alt.SetActive(false);
        }
    }

    private IEnumerator ActivationRoutineBlackout()
    {
        yield return new WaitForSeconds(0);

        PlayerPrefs.SetInt("ScoreLevel2", PlayerStats.totalScore);

        if (PlayerStats.totalScore >= 170)
        {
            MissionComplete.SetActive(true);
        }
        else
        {
            MissionFailed.SetActive(true);
        }
    }
}
