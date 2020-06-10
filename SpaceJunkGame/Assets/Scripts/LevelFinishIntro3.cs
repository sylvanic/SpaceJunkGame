using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelFinishIntro3 : MonoBehaviour
{
    public GameObject text1;
    public GameObject text2;
    public GameObject text3;
    public GameObject MissionComplete;
    public GameObject MissionFailed;
    float time;
    bool intro1playing = true;
    bool intro2playing = true;
    bool intro3playing = true;

    void Update()
    {
        time += 1 * Time.deltaTime;
        intro1();
        intro2();
        intro3();
        blackout();
    }

    public void intro1()
    {
        if (time >= 0 && intro1playing)
        {
            StartCoroutine(Text1());
            intro1playing = false;
        }
        
    }

    public void intro2()
    {
        if (time >= 10 && intro2playing)
        {
            StartCoroutine(Text2());
            intro2playing = false;
        }
            
    }

    public void intro3()
    {
        if (time >= 14 && intro3playing)
        {
            StartCoroutine(Text3());
            intro3playing = false;
        }
    }

    public void blackout()
    {
        StartCoroutine(Blackout());
    }

    private IEnumerator Text1()
    {
        yield return new WaitForSeconds(6);

        text1.SetActive(true);

        yield return new WaitForSeconds(4);

        text1.SetActive(false);
    }

    private IEnumerator Text2()
    {
        text2.SetActive(true);

        yield return new WaitForSeconds(4);

        text2.SetActive(false);
    }

    private IEnumerator Text3()
    {
        text3.SetActive(true);

        yield return new WaitForSeconds(5);

        text3.SetActive(false);
    }

    private IEnumerator Blackout()
    {
        yield return new WaitForSeconds(18);

        if (PlayerStats.totalScore > 30)
        {
            MissionComplete.SetActive(true);
        }
        else
        {
            MissionFailed.SetActive(true);
        }
    }
}
