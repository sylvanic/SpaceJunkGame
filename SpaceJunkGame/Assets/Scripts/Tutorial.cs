using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tutorial : MonoBehaviour
{
    public GameObject obj1;
    public GameObject obj2;
    public GameObject obj3;
    public GameObject obj4;
    public GameObject obj5;
    public GameObject obj6;

    private void Start()
    {
        StartCoroutine(ActivationRoutine1());
        StartCoroutine(ActivationRoutine2());
        StartCoroutine(ActivationRoutine3());
        StartCoroutine(ActivationRoutine4());
        StartCoroutine(ActivationRoutine5());
        StartCoroutine(ActivationRoutine6());
    }

    private IEnumerator ActivationRoutine1()
    {
        //Wait for 14 secs.
        yield return new WaitForSeconds(2);

        //Turn My game object that is set to false(off) to True(on).
        obj1.SetActive(true);
          
        //Turn the Game Oject back off after 1 sec.
        yield return new WaitForSeconds(6);

        //Game object will turn off
        obj1.SetActive(false);          
    }

    private IEnumerator ActivationRoutine2()
    {
        yield return new WaitForSeconds(8);

        obj2.SetActive(true);

        yield return new WaitForSeconds(6);

        obj2.SetActive(false);
    }

    private IEnumerator ActivationRoutine3()
    {
        yield return new WaitForSeconds(14);

        obj3.SetActive(true);

        yield return new WaitForSeconds(6);

        obj3.SetActive(false);
    }

    private IEnumerator ActivationRoutine4()
    {
        yield return new WaitForSeconds(20);

        obj4.SetActive(true);

        yield return new WaitForSeconds(6);

        obj4.SetActive(false);
    }

    private IEnumerator ActivationRoutine5()
    {
        yield return new WaitForSeconds(26);

        obj5.SetActive(true);

        yield return new WaitForSeconds(6);

        obj5.SetActive(false);
    }

    private IEnumerator ActivationRoutine6()
    {
        yield return new WaitForSeconds(32);

        obj6.SetActive(true);

        yield return new WaitForSeconds(6);

        obj6.SetActive(false);
    }
}
