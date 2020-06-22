using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;
using UnityEditor;

public class TutorialInteraction : MonoBehaviour
{
    public GameObject intro1;
    public GameObject intro2;
    public GameObject intro3;
    public GameObject intro3point1;
    public GameObject intro4;
    public GameObject intro5;
    public GameObject intro6;
    public GameObject intro7;
    public GameObject intro8;
    public GameObject intro9;
    public GameObject intro10;
    public GameObject intro11;
    public GameObject intro11point1;
    public GameObject intro11point2;
    public GameObject intro11point3;
    public GameObject intro11point4;
    public GameObject intro11point5;
    public GameObject intro11point6;
    public GameObject intro11point7;
    public GameObject intro11point8;
    public GameObject intro11point9;
    public GameObject intro11point10;
    public GameObject intro12;
    public GameObject intro13;
    public GameObject intro14;
    public GameObject intro14point1;
    public GameObject intro15;
    public GameObject intro16;
    public GameObject intro17;
    public GameObject astronautInteraction;
    public GameObject astronautAppear;
    public PlayerStats playerStats;
    public GameObject junkDump;
    public GameObject bigSpaceJunk;
    public GameObject upgrades;
    public GameObject upgradeNL;
    public GameObject goal1;
    public GameObject goal2;
    public GameObject goal3;
    public GameObject goal4;
    public GameObject goal5;
    public GameObject goal6;
    public GameObject helpButton;

    bool intro2popup = false;
    bool intro3popup = false;
    bool intro4popup = false;
    bool intro5popup = false;
    bool intro6popup = false;
    public bool intro7popup = false;
    public bool hitByAsteroid = false;
    public bool laserHasBeenShot = false;
    //First Intro
    bool firstIntro = true;
    public void SkipIntro1()
    {
        if (firstIntro)
        {
            intro1.SetActive(false);
            firstIntro = false;
            StopAllCoroutines();
            intro2.SetActive(true);
        }
    }
    bool secondIntro = true;
    public void SkipIntro2()
    {
        if (secondIntro)
        {
            intro2.SetActive(false);
            secondIntro = false;
            StopAllCoroutines();
            intro3.SetActive(true);
        }
    }

    bool thirdIntro = true;
    public void SkipIntro3()
    {
        if (thirdIntro)
        {
            intro3.SetActive(false);
            thirdIntro = false;
            StopAllCoroutines();
            intro3point1.SetActive(true);
        }
    }

    bool threepointoneIntro = true;
    public void SkipIntro3point1()
    {
        if (threepointoneIntro)
        {
            intro3point1.SetActive(false);
            threepointoneIntro = false;
            StopAllCoroutines();
            intro4.SetActive(true);
        }
    }

    bool fourthIntro = true;
    public void SkipIntro4()
    {
        if (fourthIntro)
        {
            intro4.SetActive(false);
            fourthIntro = false;
            StopAllCoroutines();
            intro5.SetActive(true);
        }
    }

    bool fifthIntro = true;
    public void SkipIntro5()
    {
        if (fifthIntro)
        {
            intro5.SetActive(false);
            fifthIntro = false;
            astronautInteraction.SetActive(false);
            StopAllCoroutines();
            intro2popup = true;
            goal1.SetActive(true);
        }
    }

    //Second Intro
    bool sixthIntro = true;
    public void SkipIntro6()
    {
        if (sixthIntro)
        {
            
            StartCoroutine(StartIntro2());
            intro6.SetActive(false);
            sixthIntro = false;            
            astronautInteraction.SetActive(false);
            StopAllCoroutines();
            intro3popup = true;
            goal2.SetActive(true);
        }
    }

    //Third Intro
    bool seventhIntro = true;
    public void SkipIntro7()
    {
        if (seventhIntro)
        {
            intro7.SetActive(false);
            seventhIntro = false;
            astronautInteraction.SetActive(false);
            StopAllCoroutines();
            intro4popup = true;
            goal3.SetActive(true);
        }
    }

    //Fourth Intro
    bool eighthIntro = true;
    public void SkipIntro8()
    {
        if (eighthIntro)
        {
            intro8.SetActive(false);
            eighthIntro = false;
            astronautInteraction.SetActive(false);
            StopAllCoroutines();
            intro5popup = true;
            goal4.SetActive(true);
        }
    }

    //Fifth Intro
    bool ninethIntro = true;
    public void SkipIntro9()
    {
        if (ninethIntro)
        {
            intro9.SetActive(false);
            ninethIntro = false;
            StopAllCoroutines();
            intro10.SetActive(true);
        }
    }

    bool tenthIntro = true;
    public void SkipIntro10()
    {
        if (tenthIntro)
        {
            intro10.SetActive(false);
            tenthIntro = false;
            astronautInteraction.SetActive(false);
            StopAllCoroutines();
            intro6popup = true;
            goal5.SetActive(true);
        }
    }

    //Sixth Intro
    bool eleventhIntro = true;
    public void SkipIntro11()
    {
        if (eleventhIntro)
        {
            intro11.SetActive(false);
            eleventhIntro = false;
            StopAllCoroutines();
            intro11point1.SetActive(true);
        }
    }

    bool elevenpoint1Intro = true;
    public void SkipIntro11point1()
    {
        if (elevenpoint1Intro)
        {
            intro11point1.SetActive(false);
            elevenpoint1Intro = false;
            StopAllCoroutines();
            intro11point2.SetActive(true);
        }
    }

    bool elevenpoint2Intro = true;
    public void SkipIntro11point2()
    {
        if (elevenpoint2Intro)
        {
            intro11point2.SetActive(false);
            elevenpoint2Intro = false;
            StopAllCoroutines();
            intro11point3.SetActive(true);
        }
    }

    bool elevenpoint3Intro = true;
    public void SkipIntro11point3()
    {
        if (elevenpoint3Intro)
        {
            intro11point3.SetActive(false);
            elevenpoint3Intro = false;
            astronautInteraction.SetActive(false);
            StopAllCoroutines();
            goal6.SetActive(true);
        }
    }

    //Seventh Intro
    bool elevenpoint4Intro = true;
    public void SkipIntro11point4()
    {
        if (elevenpoint4Intro)
        {
            intro11point4.SetActive(false);
            elevenpoint4Intro = false;
            StopAllCoroutines();
            intro11point5.SetActive(true);
        }
    }

    bool elevenpoint5Intro = true;
    public void SkipIntro11point5()
    {
        if (elevenpoint5Intro)
        {
            intro11point5.SetActive(false);
            elevenpoint5Intro = false;
            StopAllCoroutines();
            astronautInteraction.SetActive(false);
            intro11point6.SetActive(true);
            if (LangSwitchBool.englishTxt)
            {
                upgrades.SetActive(true);
            }
            else
            {
                upgradeNL.SetActive(true);
            }
        }
    }

    bool elevenpoint6Intro = true;
    public void SkipIntro11point6()
    {
        if (elevenpoint6Intro)
        {
            intro11point6.SetActive(false);
            elevenpoint6Intro = false;
            StopAllCoroutines();
            intro11point7.SetActive(true);
        }
    }

    bool elevenpoint7Intro = true;
    public void SkipIntro11point7()
    {
        if (elevenpoint7Intro)
        {
            intro11point7.SetActive(false);
            elevenpoint7Intro = false;
            StopAllCoroutines();
            intro11point8.SetActive(true);
        }
    }

    bool elevenpoint8Intro = true;
    public void SkipIntro11point8()
    {
        if (elevenpoint8Intro)
        {
            intro11point8.SetActive(false);
            elevenpoint8Intro = false;
            StopAllCoroutines();
            intro11point9.SetActive(true);
        }
    }

    bool elevenpoint9Intro = true;
    public void SkipIntro11point9()
    {
        if (elevenpoint9Intro)
        {
            intro11point9.SetActive(false);
            elevenpoint9Intro = false;
            StopAllCoroutines();
            intro11point10.SetActive(true);
        }
    }

    bool elevenpoint10Intro = true;
    public void SkipIntro11point10()
    {
        if (elevenpoint10Intro)
        {
            intro11point10.SetActive(false);
            if (LangSwitchBool.englishTxt)
            {
                upgrades.SetActive(false);
            }
            else
            {
                upgradeNL.SetActive(false);
            }
            astronautInteraction.SetActive(true);
            elevenpoint10Intro = false;
            StopAllCoroutines();
            intro12.SetActive(true);
        }
    }

    bool twelvethIntro = true;
    public void SkipIntro12()
    {
        if (twelvethIntro)
        {
            intro12.SetActive(false);
            twelvethIntro = false;
            StopAllCoroutines();
            intro13.SetActive(true);
        }
    }

    bool thirteenthIntro = true;
    public void SkipIntro13()
    {
        if (thirteenthIntro)
        {
            intro13.SetActive(false);
            thirteenthIntro = false;
            StopAllCoroutines();
            intro14.SetActive(true);
        }
    }

    bool fourteenthIntro = true;
    public void SkipIntro14()
    {
        if (fourteenthIntro)
        {
            intro14.SetActive(false);
            fourteenthIntro = false;
            StopAllCoroutines();
            intro14point1.SetActive(true);
            helpButton.SetActive(true);
        }
    }

    bool fourteenpoint1Intro = true;
    public void SkipIntro14point1()
    {
        if (fourteenpoint1Intro)
        {
            intro14point1.SetActive(false);
            fourteenpoint1Intro = false;
            StopAllCoroutines();
            intro15.SetActive(true);
        }
    }

    public void NextScene()
    {
        helpButton.SetActive(false);
        SceneManager.LoadScene("SelectLevel");
    }

    public void GoToMainMenu()
    {
        helpButton.SetActive(false);
        SceneManager.LoadScene("NEW_Menu");
    }

    private void Start()
    {
        StartCoroutine(StartIntro1());
    }

    void Update()
    {
        ScoreDetect();
        DetectDump();
        DetectHit();
        DetectLaser();
        if (intro7popup)
        {
            StartCoroutine(StartIntro7());
            intro7popup = false;
        }
    }

    private IEnumerator StartIntro1()
    {
        yield return new WaitForSeconds(1);
        astronautAppear.SetActive(true);
        yield return new WaitForSeconds(2);
        astronautAppear.SetActive(false);
        astronautInteraction.SetActive(true);        
        intro1.SetActive(true);       
        yield return new WaitForSeconds(5);
        intro1.SetActive(false);               
        intro2.SetActive(true);       
        yield return new WaitForSeconds(5);
        intro2.SetActive(false);        
        intro3.SetActive(true);
        yield return new WaitForSeconds(5);
        intro3.SetActive(false);
        intro3point1.SetActive(true);
        yield return new WaitForSeconds(5);
        intro3point1.SetActive(false);
        intro4.SetActive(true);
        yield return new WaitForSeconds(4);
        intro4.SetActive(false);
        intro5.SetActive(true);
        yield return new WaitForSeconds(4);
        intro5.SetActive(false);
        goal1.SetActive(true);
        astronautInteraction.SetActive(false);
        intro2popup = true;
    }

    private IEnumerator StartIntro2()
    {
        yield return new WaitForSeconds(1);
        goal1.SetActive(false);
        astronautInteraction.SetActive(true);
        intro6.SetActive(true);
        yield return new WaitForSeconds(4);
        intro6.SetActive(false);
        astronautInteraction.SetActive(false);
        intro3popup = true;
        goal2.SetActive(true);
    }

    private IEnumerator StartIntro3()
    {
        yield return new WaitForSeconds(1);
        goal2.SetActive(false);
        astronautInteraction.SetActive(true);
        intro7.SetActive(true);
        yield return new WaitForSeconds(4);
        intro7.SetActive(false);
        astronautInteraction.SetActive(false);
        intro4popup = true;
        goal3.SetActive(true);
    }

    private IEnumerator StartIntro4()
    {
        yield return new WaitForSeconds(1);
        goal3.SetActive(false);
        astronautInteraction.SetActive(true);
        intro8.SetActive(true);
        yield return new WaitForSeconds(4);
        intro8.SetActive(false);
        astronautInteraction.SetActive(false);
        intro5popup = true;
        goal4.SetActive(true);
    }

    public IEnumerator StartIntro5()
    {
        yield return new WaitForSeconds(1);
        goal4.SetActive(false);
        astronautInteraction.SetActive(true);
        intro9.SetActive(true);
        yield return new WaitForSeconds(4);
        intro9.SetActive(false);
        intro10.SetActive(true);
        yield return new WaitForSeconds(4);
        intro10.SetActive(false);
        astronautInteraction.SetActive(false);
        intro6popup = true;
        goal5.SetActive(true);
    }

    private IEnumerator StartIntro6()
    {
        yield return new WaitForSeconds(1);
        goal5.SetActive(false);
        astronautInteraction.SetActive(true);
        intro11.SetActive(true);
        yield return new WaitForSeconds(4);
        intro11.SetActive(false);
        intro11point1.SetActive(true);
        yield return new WaitForSeconds(4);
        intro11point1.SetActive(false);
        intro11point2.SetActive(true);
        yield return new WaitForSeconds(4);
        intro11point2.SetActive(false);
        intro11point3.SetActive(true);
        yield return new WaitForSeconds(4);
        intro11point3.SetActive(false);
        astronautInteraction.SetActive(false);
        goal6.SetActive(true);
    }
    public IEnumerator StartIntro7()
    {
        goal6.SetActive(false);
        astronautInteraction.SetActive(true);
        intro11point4.SetActive(true);
        yield return new WaitForSeconds(4);
        intro11point4.SetActive(false);
        intro11point5.SetActive(true);
        yield return new WaitForSeconds(4);
        intro11point5.SetActive(false);
        astronautInteraction.SetActive(false);
        upgrades.SetActive(true);
        intro11point6.SetActive(true);
        yield return new WaitForSeconds(4);
        intro11point6.SetActive(false);
        intro11point7.SetActive(true);
        yield return new WaitForSeconds(4);
        intro11point7.SetActive(false);
        intro11point8.SetActive(true);
        yield return new WaitForSeconds(4);
        intro11point8.SetActive(false);
        intro11point9.SetActive(true);
        yield return new WaitForSeconds(4);
        intro11point9.SetActive(false);
        intro11point10.SetActive(true);
        yield return new WaitForSeconds(4);
        intro11point10.SetActive(false);
        upgrades.SetActive(false);
        intro12.SetActive(true);
        yield return new WaitForSeconds(4);
        intro12.SetActive(false);
        intro13.SetActive(true);
        yield return new WaitForSeconds(4);
        intro13.SetActive(false);
        intro14.SetActive(true);
        yield return new WaitForSeconds(5);
        intro14.SetActive(false);
        intro14point1.SetActive(true);
        helpButton.SetActive(true);
        yield return new WaitForSeconds(5);
        intro14point1.SetActive(false);
        helpButton.SetActive(false);
        intro15.SetActive(true);
    }

    public void DetectInput()
    {
        if (intro2popup)
        {
                StartCoroutine(StartIntro2());
                intro2popup = false;

        }
    }

    public void ScoreDetect()
    {
        if ((playerStats.capacity == 3 || junkDump.GetComponent<JunkDump>().junkDumped >= 1) && intro3popup)
        {
                StartCoroutine(StartIntro3());
                intro3popup = false;
        }
    }


    public void DetectDump()
    {
        if (junkDump.GetComponent<JunkDump>().junkDumped >= 1 && intro4popup)
        {
                StartCoroutine(StartIntro4());
                intro4popup = false;
        }
    }

    public void DetectHit()
    {
        if(hitByAsteroid && intro5popup)
        {
             StartCoroutine(StartIntro5());
             intro5popup = false;
        }
    }

    public void DetectLaser()
    {
        if (laserHasBeenShot && intro6popup)
        {
                StartCoroutine(StartIntro6());
                intro6popup = false;
        }
    }

    public void LaserShot()
    {
        laserHasBeenShot = true;
    }

    public void Ready()
    {
        intro15.SetActive(false);
        intro16.SetActive(true);
    }

    public void Ready2()
    {
        intro16.SetActive(false);
        SceneManager.LoadScene("SelectLevel");
    }

    public void NotReady()
    {
        intro15.SetActive(false);
        intro17.SetActive(true);
    }

    public void NotReady2()
    {
        intro17.SetActive(false);
        SceneManager.LoadScene("Tutorial");
    }
}
