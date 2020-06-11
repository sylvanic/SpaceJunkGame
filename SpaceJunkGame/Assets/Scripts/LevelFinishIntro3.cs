using System;
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
    public GameObject junkAnim;
    public GameObject junkSkipped;
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
        yield return new WaitForSeconds(3);

    }

    private IEnumerator Text3()
    {
        text3.SetActive(true);
        yield return new WaitForSeconds(2);
        text3.SetActive(false);
        yield return new WaitForSeconds(5);
    }
    private IEnumerator Text4()
    {
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
        yield return new WaitForSeconds(8);
        text6.SetActive(false);
    }

    private IEnumerator Text7()
    {
        text7.SetActive(true);
        yield return new WaitForSeconds(8);
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

    bool firstIntro = true;
    public void SkipIntro1()
    {
        if (firstIntro && time >= 6)
        {
            text1.SetActive(false);
            intro1playing = false;
            firstIntro = false;
            StopAllCoroutines();
            time = 10;
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

    bool secondIntro = true;
    public void SkipIntro2()
    {
        if (secondIntro && time >= 10)
        {
            text2.SetActive(false);
            astronaut.SetActive(false);
            intro2playing = false;
            secondIntro = false;
            StopAllCoroutines();
            time = 18;
        }
    }

    public void intro3()
    {
        if (intro3playing && time >= 18)
        {
            StartCoroutine(Text3());
            intro3playing = false;
        }
    }

    bool thirdIntro = true;
    public void SkipIntro3()
    {
        if (thirdIntro && time >= 18)
        {
            text3.SetActive(false);
            junkAnim.SetActive(false);
            junkSkipped.SetActive(true);
            intro3playing = false;
            thirdIntro = false;
            StopAllCoroutines();
            time = 25;
        }
    }

    public void intro4()
    {
        if (intro4playing && time >= 25)
        {
            StartCoroutine(Text4());
            intro4playing = false;
        }
    }

    bool fourthIntro = true;
    public void SkipIntro4()
    {
        if (fourthIntro && time >= 25)
        {
            text4.SetActive(false);
            intro4playing = false;
            fourthIntro = false;
            StopAllCoroutines();
            time = 29;
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

    bool fifthIntro = true;
    public void SkipIntro5()
    {
        if (fifthIntro && time >= 29)
        {
            text5.SetActive(false);
            intro5playing = false;
            fifthIntro = false;
            StopAllCoroutines();
            time = 34;
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

    bool sixthIntro = true;
    public void SkipIntro6()
    {
        if (sixthIntro && time >= 34)
        {
            text6.SetActive(false);
            intro6playing = false;
            sixthIntro = false;
            StopAllCoroutines();
            time = 42;
        }
    }


    public void intro7()
    {
        if (intro7playing && time >= 42)
        {
            StartCoroutine(Text7());
            intro7playing = false;
        }
    }

    bool seventhIntro = true;
    public void SkipIntro7()
    {
        if (seventhIntro && time >= 42)
        {
            text7.SetActive(false);
            intro7playing = false;
            seventhIntro = false;
            StopAllCoroutines();
            time = 50;
        }
    }

    public void intro8()
    {
        if (intro8playing && time >= 50)
        {
            StartCoroutine(Text8());
            intro8playing = false;
        }
    }

    bool eigthIntro = true;
    public void SkipIntro8()
    {
        if (eigthIntro && time >= 42)
        {
            text8.SetActive(false);
            intro8playing = false;
            eigthIntro = false;
            StopAllCoroutines();
            time = 55;
        }
    }
    public void intro9()
    {
        if (intro9playing && time >= 55)
        {
            StartCoroutine(Text9());
            intro9playing = false;
        }
    }

    bool ninthIntro = true;
    public void SkipIntro9()
    {
        if (ninthIntro && time >= 55)
        {
            text9.SetActive(false);
            intro9playing = false;
            ninthIntro = false;
            StopAllCoroutines();
            time = 60;
        }
    }
    public void blackout()
    {
        if (blackoutplaying && time >= 60)
        { 
            StartCoroutine(Blackout());
            blackoutplaying = false;
        }
    }
}
