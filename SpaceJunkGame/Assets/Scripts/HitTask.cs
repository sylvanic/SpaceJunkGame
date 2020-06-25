using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class HitTask : Objective
{
    private int hits;
    public int requiredHits;

    public static string hitTaskTxt;

    public TextMeshProUGUI hitTask;

    private void Awake()
    {
        if (LangSwitchBool.englishTxt)
        {
            hitTaskTxt = "Get hit by an asteroid: ";
        }
        else
        {
            hitTaskTxt = "Word door een asteroid\ngeraakt: ";
        }
    }

    private void Update()
    {
        hitTask.text = string.Format(hitTaskTxt + "{0}/{1}", hits, requiredHits);
        hits = PlayerStats.hitAmount;

        if (hits >= requiredHits)
        {
            hits = requiredHits;
        }

    }


    public override bool IsComplete()
    {
        return (hits >= requiredHits);
    }

    public override void Complete()
    {
        ResultScreens.checkChallengedCompleted = true;
        hitTask.color = Color.yellow;
    }
}
