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

    public GameObject blackscreen;

    public GameObject astronautInteraction;
    public GameObject astronautAppear;

    public PlayerStats playerStats;

    public GameObject asteroidCollide;
    public GameObject junkDump;

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
            blackscreen.SetActive(false);
            astronautInteraction.SetActive(false);
            StopAllCoroutines();           
        }
    }

    //Second Intro
    bool sixthIntro = true;
    public void SkipIntro6()
    {
        if (sixthIntro)
        {
            intro6.SetActive(false);
            sixthIntro = false;            
            astronautInteraction.SetActive(false);
            StopAllCoroutines();
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
        }
    }

    public void NextScene()
    {
        SceneManager.LoadScene("GameTest");
    }

    void Update()
    {
        ShowIntro();
        DetectInput();
        ScoreDetect();
        DetectDump();
        //DetectAsteroid();
    }

    private IEnumerator StartIntro1()
    {
        yield return new WaitForSeconds(1);
        blackscreen.SetActive(true);
        astronautAppear.SetActive(true);
        yield return new WaitForSeconds(2);
        astronautAppear.SetActive(false);
        astronautInteraction.SetActive(true);        
        intro1.SetActive(true);       
        yield return new WaitForSeconds(3);
        intro1.SetActive(false);               
        intro2.SetActive(true);       
        yield return new WaitForSeconds(3);
        intro2.SetActive(false);        
        intro3.SetActive(true);
        yield return new WaitForSeconds(3);
        intro3.SetActive(false);
        intro4.SetActive(true);
        yield return new WaitForSeconds(3);
        intro4.SetActive(false);
        intro5.SetActive(true);
        yield return new WaitForSeconds(3);
        intro5.SetActive(false);
        blackscreen.SetActive(false);
        astronautInteraction.SetActive(false);
    }

    private IEnumerator StartIntro2()
    {
        yield return new WaitForSeconds(1);
        astronautInteraction.SetActive(true);
        intro6.SetActive(true);
        yield return new WaitForSeconds(3);
        intro6.SetActive(false);
        astronautInteraction.SetActive(false);
    }

    private IEnumerator StartIntro3()
    {
        yield return new WaitForSeconds(1);
        astronautInteraction.SetActive(true);
        intro7.SetActive(true);
        yield return new WaitForSeconds(3);
        intro7.SetActive(false);
        astronautInteraction.SetActive(false);
    }

    public IEnumerator StartIntro4()
    {
        yield return new WaitForSeconds(1);
        astronautInteraction.SetActive(true);
        intro8.SetActive(true);
        yield return new WaitForSeconds(3);
        intro8.SetActive(false);
        astronautInteraction.SetActive(false);
        SceneManager.LoadScene("GameTest");
    }

    /*private IEnumerator StartIntro5()
    {
        yield return new WaitForSeconds(1);
        astronautInteraction.SetActive(true);
        intro9.SetActive(true);
        yield return new WaitForSeconds(3);
        intro9.SetActive(false);
        astronautInteraction.SetActive(false);
    }*/

    bool intro1popup = true;
    public void ShowIntro()
    {
        if (Time.timeScale == 1)
        {
            if (intro1popup)
            {
                StartCoroutine(StartIntro1());
                intro1popup = false;
            }
        }
    }

    bool intro2popup = true;
    public void DetectInput()
    {
        if (Input.GetKeyDown(KeyCode.W))
        {
            if (intro2popup)
            {
                StartCoroutine(StartIntro2());
                intro2popup = false;
            }
        }
    }

    bool intro3popup = true;
    public void ScoreDetect()
    {
        if (playerStats.capacity == 3)
        {
            if (intro3popup)
            {
                StartCoroutine(StartIntro3());
                intro3popup = false;
            }
        }
    }

    bool intro4popup = true;
    public void DetectDump()
    {
        if(junkDump.GetComponent<JunkDump>().junkDumped >= 3)
        {
            if (intro4popup)
            {
                StartCoroutine(StartIntro4());
                intro4popup = false;
            }
        }
    }

    /*bool intro5popup = true;
    public void DetectAsteroid()
    {                      
        if (intro5popup)
           {
              StartCoroutine(StartIntro5());
              intro5popup = false;
           }                 
    }*/
}
