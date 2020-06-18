using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HitTask : Objective
{
    private int hits;
    public int requiredHits;

    public static string hitTaskTxt; 

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
    }

    public override void DrawHUD()
    {
        GUI.Label(new Rect(1565, 455, 300, 100),string.Format(hitTaskTxt +"{0}/{1}", hits, requiredHits), ObjectiveManager.guiStyle);
    }
}
