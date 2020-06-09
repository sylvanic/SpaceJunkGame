using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class TutorialInteraction : MonoBehaviour
{
    public GameObject intro1;
    public GameObject intro2;
    public GameObject intro3;
    public GameObject intro4;
    public GameObject intro5;
    public GameObject intro6;
    public GameObject intro7;
    public GameObject intro8;
    public GameObject intro9;
    public GameObject intro10;
    public GameObject intro11;
    public GameObject intro12;
    public GameObject intro13;
    public GameObject intro14;
    public GameObject intro15;
    public GameObject astronautInteraction;
    public GameObject astronautAppear;
    public PlayerStats playerStats;
    public GameObject junkDump;

    bool intro2popup = false;
    bool intro3popup = false;
    bool intro4popup = false;
    bool intro5popup = false;
    bool intro6popup = false;
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
            intro15.SetActive(true);
        }
    }

    bool fifteenthIntro = true;
    public void SkipIntro15()
    {
        if (fifteenthIntro)
        {
            intro15.SetActive(false);
            fifteenthIntro = false;
            astronautInteraction.SetActive(false);
            StopAllCoroutines();
            SceneManager.LoadScene("GameTest");
        }
    }

    public void NextScene()
    {
        SceneManager.LoadScene("SelectLevel");
    }

    public void GoToMainMenu()
    {
        SceneManager.LoadScene("NEW_Menu");
    }

    private void Start()
    {
        StartCoroutine(StartIntro1());
    }

    void Update()
    {
        DetectInput();
        ScoreDetect();
        DetectDump();
        DetectHit();
        DetectLaser();
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
        intro4.SetActive(true);
        yield return new WaitForSeconds(4);
        intro4.SetActive(false);
        intro5.SetActive(true);
        yield return new WaitForSeconds(4);
        intro5.SetActive(false);
        astronautInteraction.SetActive(false);
        intro2popup = true;
    }

    private IEnumerator StartIntro2()
    {
        yield return new WaitForSeconds(1);
        astronautInteraction.SetActive(true);
        intro6.SetActive(true);
        yield return new WaitForSeconds(4);
        intro6.SetActive(false);
        astronautInteraction.SetActive(false);
        intro3popup = true;
    }

    private IEnumerator StartIntro3()
    {
        yield return new WaitForSeconds(1);
        astronautInteraction.SetActive(true);
        intro7.SetActive(true);
        yield return new WaitForSeconds(4);
        intro7.SetActive(false);
        astronautInteraction.SetActive(false);
        intro4popup = true;
    }

    private IEnumerator StartIntro4()
    {
        yield return new WaitForSeconds(1);
        astronautInteraction.SetActive(true);
        intro8.SetActive(true);
        yield return new WaitForSeconds(4);
        intro8.SetActive(false);
        astronautInteraction.SetActive(false);
        intro5popup = true;
    }

    public IEnumerator StartIntro5()
    {
        yield return new WaitForSeconds(1);
        astronautInteraction.SetActive(true);
        intro9.SetActive(true);
        yield return new WaitForSeconds(4);
        intro9.SetActive(false);
        intro10.SetActive(true);
        yield return new WaitForSeconds(4);
        intro10.SetActive(false);
        astronautInteraction.SetActive(false);
        intro6popup = true;
    }

    private IEnumerator StartIntro6()
    {
        yield return new WaitForSeconds(1);
        astronautInteraction.SetActive(true);
        intro11.SetActive(true);
        yield return new WaitForSeconds(4);
        intro11.SetActive(false);
        intro12.SetActive(true);
        yield return new WaitForSeconds(4);
        intro12.SetActive(false);
        intro13.SetActive(true);
        yield return new WaitForSeconds(4);
        intro13.SetActive(false);
        intro14.SetActive(true);
        yield return new WaitForSeconds(5);
        intro14.SetActive(false);
        intro15.SetActive(true);
        yield return new WaitForSeconds(4);
        intro15.SetActive(false);
        astronautInteraction.SetActive(false);
        SceneManager.LoadScene("GameTest");
    }

    public void DetectInput()
    {
        if (Input.GetKeyDown(KeyCode.W) && intro2popup)
        {
                StartCoroutine(StartIntro2());
                intro2popup = false;

        }
    }

    public void ScoreDetect()
    {
        if ((playerStats.capacity == 3 || junkDump.GetComponent<JunkDump>().junkDumped >= 3) && intro3popup)
        {
                StartCoroutine(StartIntro3());
                intro3popup = false;
        }
    }


    public void DetectDump()
    {
        if (junkDump.GetComponent<JunkDump>().junkDumped >= 3 && intro4popup)
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
}
