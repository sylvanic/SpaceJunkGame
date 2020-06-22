using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HitTask : Objective
{
    private int hits;
    public int requiredHits;

    public static string hitTaskTxt;

    private GUIStyle guiStyle = new GUIStyle();

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

        guiStyle.normal.textColor = Color.white;
        guiStyle.fontSize = 25;

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
        ResultScreens.checkChallengedCompleted = true;
        guiStyle.normal.textColor = Color.yellow;
       

    }

    public override void DrawHUD()
    {
        
        GUI.Label(new Rect(1565, 455, 300, 100), string.Format(hitTaskTxt + "{0}/{1}", hits, requiredHits), guiStyle);
    }
}
