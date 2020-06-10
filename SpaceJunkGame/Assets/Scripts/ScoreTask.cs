using System.Collections;
using System.Collections.Generic;
using UnityEditorInternal;
using UnityEngine;

public class ScoreTask : Objective
{
    private int points;
    public int requiredPoints;

    private void Update()
    {
        points = PlayerStats.totalScore;

        if (points >= requiredPoints)
        {
            points = requiredPoints;
        }
    }

    public override bool IsComplete()
    {
        return (points >= requiredPoints);
    }

    public override void Complete()
    {
    }

    public override void DrawHUD()
    {
        GUI.Label(new Rect(1565, 215, 300, 100),string.Format("Obtain a score of {0}/{1} points", points, requiredPoints), ObjectiveManager.guiStyle);
    }
}
