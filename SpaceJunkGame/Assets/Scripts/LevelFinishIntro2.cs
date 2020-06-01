using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelFinishIntro2 : MonoBehaviour
{
    public GameObject intro;
    public GameObject text1;
    public GameObject text2;
    public GameObject text3;
    public GameObject blackout;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(ActivationRoutineCanvas());
        StartCoroutine(ActivationRoutineText());
        StartCoroutine(ActivationRoutineText2());
        StartCoroutine(ActivationRoutineText3());
        StartCoroutine(ActivationRoutineBlackout());
    }

    private IEnumerator ActivationRoutineCanvas()
    {
        yield return new WaitForSeconds(1);

        intro.SetActive(true);
    }

    private IEnumerator ActivationRoutineText()
    {
        yield return new WaitForSeconds(3);

        text1.SetActive(true);

        yield return new WaitForSeconds(3);

        text1.SetActive(false);
    }

    private IEnumerator ActivationRoutineText2()
    {
        yield return new WaitForSeconds(8);

        text2.SetActive(true);

        yield return new WaitForSeconds(3);

        text2.SetActive(false);
    }

    private IEnumerator ActivationRoutineText3()
    {
        yield return new WaitForSeconds(12);

        text3.SetActive(true);

        yield return new WaitForSeconds(3);

        text3.SetActive(false);
    }

    private IEnumerator ActivationRoutineBlackout()
    {
        yield return new WaitForSeconds(16);

        blackout.SetActive(true);
    }
}
