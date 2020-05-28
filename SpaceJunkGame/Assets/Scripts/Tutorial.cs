using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Tutorial : MonoBehaviour
{
    public GameObject introduction;
    public GameObject obj1;
    public GameObject obj2;
    public GameObject obj3;
    public GameObject obj4;
    public GameObject obj5;
    public GameObject obj6;
    public GameObject obj7;
    public GameObject obj8;
    public GameObject obj9;
    public GameObject obj10;
    public GameObject obj11;
    public GameObject nextLevel;


    private void Start()
    {
        StartCoroutine(ActivationRoutine0());
        StartCoroutine(ActivationRoutine1());
        StartCoroutine(ActivationRoutine2());
        StartCoroutine(ActivationRoutine3());
        StartCoroutine(ActivationRoutine4());
        StartCoroutine(ActivationRoutine5());
        StartCoroutine(ActivationRoutine6());
        StartCoroutine(ActivationRoutine7());
        StartCoroutine(ActivationRoutine8());
        StartCoroutine(ActivationRoutine9());
        StartCoroutine(ActivationRoutine10());
        StartCoroutine(ActivationRoutine11());
        StartCoroutine(ActivationNextLevel());


    }

    public void SkipTutorial()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    private IEnumerator ActivationRoutine0()
    {       
        yield return new WaitForSeconds(1);

        introduction.SetActive(true);
    }

    private IEnumerator ActivationRoutine1()
    {
        //Wait for 14 secs.
        yield return new WaitForSeconds(3);

        //Turn My game object that is set to false(off) to True(on).
        obj1.SetActive(true);
          
        //Turn the Game Oject back off after 1 sec.
        yield return new WaitForSeconds(4);

        //Game object will turn off
        obj1.SetActive(false);          
    }

    private IEnumerator ActivationRoutine2()
    {
        yield return new WaitForSeconds(7);

        obj2.SetActive(true);

        yield return new WaitForSeconds(4);

        obj2.SetActive(false);
    }

    private IEnumerator ActivationRoutine3()
    {
        yield return new WaitForSeconds(11);

        obj3.SetActive(true);

        yield return new WaitForSeconds(4);

        obj3.SetActive(false);
    }

    private IEnumerator ActivationRoutine4()
    {
        yield return new WaitForSeconds(15);

        obj4.SetActive(true);

        yield return new WaitForSeconds(4);

        obj4.SetActive(false);
    }

    private IEnumerator ActivationRoutine5()
    {
        yield return new WaitForSeconds(19);

        obj5.SetActive(true);

        yield return new WaitForSeconds(4);

        obj5.SetActive(false);
    }

    private IEnumerator ActivationRoutine6()
    {
        yield return new WaitForSeconds(23);

        obj6.SetActive(true);

        yield return new WaitForSeconds(4);

        obj6.SetActive(false);
    }

    private IEnumerator ActivationRoutine7()
    {
        yield return new WaitForSeconds(27);

        obj7.SetActive(true);

        yield return new WaitForSeconds(4);

        obj7.SetActive(false);
    }

    private IEnumerator ActivationRoutine8()
    {
        yield return new WaitForSeconds(31);

        obj8.SetActive(true);

        yield return new WaitForSeconds(4);

        obj8.SetActive(false);
    }

    private IEnumerator ActivationRoutine9()
    {
        yield return new WaitForSeconds(35);

        obj9.SetActive(true);

        yield return new WaitForSeconds(4);

        obj9.SetActive(false);
    }

    private IEnumerator ActivationRoutine10()
    {
        yield return new WaitForSeconds(39);

        obj10.SetActive(true);

        yield return new WaitForSeconds(4);

        obj10.SetActive(false);
    }

    private IEnumerator ActivationRoutine11()
    {
        yield return new WaitForSeconds(43);

        obj11.SetActive(true);
    }

    private IEnumerator ActivationNextLevel()
    {
        yield return new WaitForSeconds(45);

        nextLevel.SetActive(true);
    }
}
