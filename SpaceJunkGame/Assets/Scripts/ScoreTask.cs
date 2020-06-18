using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreTask : Objective
{
    private int points;
    public int requiredPoints;

    public static string scoreTaskTxt; 

    private void Awake()
    {
        if (LangSwitchBool.englishTxt)
        {
            scoreTaskTxt = "Obtain a score of ";
        }
        else
        {
            scoreTaskTxt = "Verzamel punten: ";
        }
    }
        
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
        GUI.Label(new Rect(1565, 215, 300, 100),string.Format(scoreTaskTxt + "{0}/{1}", points, requiredPoints), ObjectiveManager.guiStyle);
    }
}
