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
    }


    public override bool IsComplete()
    {
        if (hits >= requiredHits)
        {
            hits = requiredHits;
        }
        return (hits >= requiredHits);
    }

    public override void Complete()
    {
    }

    public override void DrawHUD()
    {
        GUI.Label(new Rect(1565, 455, 300, 100),string.Format("Get it by an asteroid {0}/{1} times", hits, requiredHits), ObjectiveManager.guiStyle);
    }
}
