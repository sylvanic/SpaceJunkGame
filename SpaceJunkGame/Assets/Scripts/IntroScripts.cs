using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class IntroScripts : MonoBehaviour
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
    public GameObject intro16;

    public GameObject blackscreen;

    public GameObject astronautInteraction;
    public GameObject astronautAppear;

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
            blackscreen.SetActive(false);
            astronautInteraction.SetActive(false);
            StopAllCoroutines();            
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

    bool sixthIntro = true;
    public void SkipIntro6()
    {
        if (sixthIntro)
        {
            intro6.SetActive(false);
            sixthIntro = false;
            StopAllCoroutines();
            intro7.SetActive(true);
        }
    }

    bool seventhIntro = true;
    public void SkipIntro7()
    {
        if (seventhIntro)
        {
            intro7.SetActive(false);
            sixthIntro = false;
            blackscreen.SetActive(false);
            astronautInteraction.SetActive(false);           
            StopAllCoroutines();
        }
    }

    bool eightthIntro = true;
    public void SkipIntro8()
    {
        if (eightthIntro)
        {
            intro8.SetActive(false);
            eightthIntro = false;
            StopAllCoroutines();
            intro9.SetActive(true);
        }
    }

    bool ninethIntro = true;
    public void SkipIntro9()
    {
        if (ninethIntro)
        {
            intro9.SetActive(false);
            ninethIntro = false;
            blackscreen.SetActive(false);
            astronautInteraction.SetActive(false);
            StopAllCoroutines();
        }
    }

    bool tenthIntro = true;
    public void SkipIntro10()
    {
        if (tenthIntro)
        {
            intro10.SetActive(false);
            tenthIntro = false;
            StopAllCoroutines();
            intro11.SetActive(true);
        }
    }

    bool eleventhIntro = true;
    public void SkipIntro11()
    {
        if (eleventhIntro)
        {
            intro11.SetActive(false);
            eleventhIntro = false;
            blackscreen.SetActive(false);
            astronautInteraction.SetActive(false);
            StopAllCoroutines();
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
            StopAllCoroutines();
            intro16.SetActive(true);
        }
    }

    bool sixteenthIntro = true;
    public void SkipIntro16()
    {
        if (sixteenthIntro)
        {
            intro16.SetActive(false);
            sixteenthIntro = false;
            blackscreen.SetActive(false);
            astronautInteraction.SetActive(false);
            StopAllCoroutines();           
        }
    }

    void Update()
    {
        ShowIntro();
        DetectInput();
        CollectCubes();
        AsteroidCollide();
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
        blackscreen.SetActive(false);
        astronautInteraction.SetActive(false);
    }

    private IEnumerator StartIntro2()
    {
        yield return new WaitForSeconds(1);
        blackscreen.SetActive(true);
        astronautInteraction.SetActive(true);
        intro4.SetActive(true);
        yield return new WaitForSeconds(3);
        intro4.SetActive(false);
        intro5.SetActive(true);
        yield return new WaitForSeconds(3);
        blackscreen.SetActive(false);
        astronautInteraction.SetActive(false);
        intro5.SetActive(false);
    }

    private IEnumerator StartIntro3()
    {
        yield return new WaitForSeconds(1);
        blackscreen.SetActive(true);
        astronautInteraction.SetActive(true);
        intro6.SetActive(true);
        yield return new WaitForSeconds(3);
        intro6.SetActive(false);
        intro7.SetActive(true);
        yield return new WaitForSeconds(3);
        blackscreen.SetActive(false);
        astronautInteraction.SetActive(false);
        intro7.SetActive(false);
    }

    private IEnumerator StartIntro4()
    {
        yield return new WaitForSeconds(1);
        blackscreen.SetActive(true);
        astronautInteraction.SetActive(true);
        intro8.SetActive(true);
        yield return new WaitForSeconds(3);
        intro8.SetActive(false);
        intro9.SetActive(true);
        yield return new WaitForSeconds(3);
        blackscreen.SetActive(false);
        astronautInteraction.SetActive(false);
        intro9.SetActive(false);
    }

    private IEnumerator StartIntro5()
    {
        yield return new WaitForSeconds(1);
        blackscreen.SetActive(true);
        astronautInteraction.SetActive(true);
        intro10.SetActive(true);
        yield return new WaitForSeconds(3);
        intro10.SetActive(false);
        intro11.SetActive(true);
        yield return new WaitForSeconds(3);
        blackscreen.SetActive(false);
        astronautInteraction.SetActive(false);
        intro11.SetActive(false);
    }

    private IEnumerator StartIntro6()
    {
        yield return new WaitForSeconds(1);
        blackscreen.SetActive(true);
        astronautAppear.SetActive(true);
        yield return new WaitForSeconds(2);
        astronautAppear.SetActive(false);
        astronautInteraction.SetActive(true);
        intro12.SetActive(true);
        yield return new WaitForSeconds(3);
        intro12.SetActive(false);
        intro13.SetActive(true);
        yield return new WaitForSeconds(3);
        intro13.SetActive(false);
        intro14.SetActive(true);
        yield return new WaitForSeconds(3);
        intro14.SetActive(false);
        intro15.SetActive(true);
        yield return new WaitForSeconds(3);
        intro15.SetActive(false);
        intro16.SetActive(true);
        yield return new WaitForSeconds(3);
        intro16.SetActive(false);
        blackscreen.SetActive(false);
        astronautInteraction.SetActive(false);
    }

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
    public void CollectCubes()
    {
        if (Input.GetKeyDown(KeyCode.S))
        {
            if (intro3popup)
            {
                StartCoroutine(StartIntro3());
                intro3popup = false;
            }
        }
    }

    bool intro4popup = true;
    public void AsteroidCollide()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            if (intro4popup)
            {
                StartCoroutine(StartIntro4());
                intro4popup = false;
            }
        }
    }

    bool intro5popup = true;
    public void AsteroidDestroyed()
    {
        if (Input.GetKeyDown(KeyCode.K))
        {
            if (intro5popup)
            {
                StartCoroutine(StartIntro5());
                intro5popup = false;
            }
        }
    }

    bool intro6popup = true;
    public void UpgradeShip()
    {
        if (Input.GetKeyDown(KeyCode.J))
        {
            if (intro6popup)
            {
                StartCoroutine(StartIntro6());
                intro6popup = false;
            }
        }
    }
}
