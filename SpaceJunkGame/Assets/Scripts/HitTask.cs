using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HitTask : Objective
{
    private int hits;
    public int requiredHits;

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
        GUI.Label(new Rect(1565, 455, 300, 100),string.Format(LangSwitchBool.hitTaskTxt, hits, requiredHits), ObjectiveManager.guiStyle);
    }
}
