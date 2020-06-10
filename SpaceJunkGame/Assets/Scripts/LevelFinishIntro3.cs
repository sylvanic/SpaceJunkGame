﻿using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelFinishIntro3 : MonoBehaviour
{
    public GameObject astronaut;
    public GameObject text1;
    public GameObject text2;
    public GameObject text3;
    public GameObject text4;
    public GameObject text5;
    public GameObject text6;
    public GameObject text7;
    public GameObject text8;
    public GameObject text9;
    public GameObject MissionComplete;
    public GameObject MissionFailed;
    float time;
    bool intro1playing = true;
    bool intro2playing = true;
    bool intro3playing = true;
    bool intro4playing = true;
    bool intro5playing = true;
    bool intro6playing = true;
    bool intro7playing = true;
    bool intro8playing = true;
    bool intro9playing = true;
    bool blackoutplaying = true;

    void Update()
    {
        time += 1 * Time.deltaTime;
        print(time);
        intro1();
        intro2();
        intro3();
        intro4();
        intro5();
        intro6();
        intro7();
        intro8();
        intro9();
        blackout();
    }

    private IEnumerator Text1()
    {
        text1.SetActive(true);

        yield return new WaitForSeconds(4);

        text1.SetActive(false);
    }

    private IEnumerator Text2()
    {
        text2.SetActive(true);

        yield return new WaitForSeconds(5);

        text2.SetActive(false);

    }

    private IEnumerator Text3()
    {
        yield return new WaitForSeconds(3);
        text3.SetActive(true);
        yield return new WaitForSeconds(2);
        text3.SetActive(false);
    }
    private IEnumerator Text4()
    {
        yield return new WaitForSeconds(5);
        text4.SetActive(true);
        yield return new WaitForSeconds(4);
        text4.SetActive(false);
    }

    private IEnumerator Text5()
    {
        text5.SetActive(true);
        yield return new WaitForSeconds(5);
        text5.SetActive(false);
    }

    private IEnumerator Text6()
    {
        text6.SetActive(true);
        yield return new WaitForSeconds(5);
        text6.SetActive(false);
    }

    private IEnumerator Text7()
    {
        text7.SetActive(true);
        yield return new WaitForSeconds(7);
        text7.SetActive(false);
    }

    private IEnumerator Text8()
    {
        text8.SetActive(true);
        yield return new WaitForSeconds(5);
        text8.SetActive(false);
    }

    private IEnumerator Text9()
    {
        text9.SetActive(true);
        yield return new WaitForSeconds(5);
        text9.SetActive(false);
    }


    private IEnumerator Blackout()
    {
        yield return new WaitForSeconds(1);

        if (PlayerStats.totalScore > 30)
        {
            MissionComplete.SetActive(true);
        }
        else
        {
            MissionFailed.SetActive(true);
        }
    }

    public void intro1()
    {
        if (intro1playing && time >= 6)
        {
            StartCoroutine(Text1());
            intro1playing = false;
        }
    }

    public void intro2()
    {
        if (intro2playing && time >=10)
        {
            StartCoroutine(Text2());
            intro2playing = false;
        }
    }

    public void intro3()
    {
        if (intro3playing && time >= 15)
        {
            StartCoroutine(Text3());
            intro3playing = false;
        }
    }

    public void intro4()
    {
        if (intro4playing && time >= 20)
        {
            StartCoroutine(Text4());
            intro4playing = false;
        }
    }

    public void intro5()
    {
        if(intro5playing && time >= 29)
        {
            StartCoroutine(Text5());
            intro5playing = false;
        }
    }

    public void intro6()
    {
        if (intro6playing && time >= 34)
        {
            StartCoroutine(Text6());
            intro6playing = false;
        }
    }

    public void intro7()
    {
        if (intro7playing && time >= 39)
        {
            StartCoroutine(Text7());
            intro7playing = false;
        }
    }

    public void intro8()
    {
        if (intro8playing && time >= 46)
        {
            StartCoroutine(Text8());
            intro8playing = false;
        }
    }
    public void intro9()
    {
        if (intro9playing && time >= 51)
        {
            StartCoroutine(Text9());
            intro9playing = false;
        }
    }

    public void blackout()
    {
        if (blackoutplaying && time >= 55)
        { 
            StartCoroutine(Blackout());
            blackoutplaying = false;
        }
    }
}
