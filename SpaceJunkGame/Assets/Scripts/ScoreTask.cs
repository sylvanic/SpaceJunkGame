using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreTask : Objective
{
    private int points;
    public int requiredPoints;

    public static string scoreTaskTxt;

    public GUIStyle guiStyle = new GUIStyle();

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

        guiStyle.normal.textColor = Color.white;
        guiStyle.fontSize = 25;
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
        guiStyle.normal.textColor = Color.black;
    }

    public override void DrawHUD()
    {
        guiStyle.normal.textColor = Color.HSVToRGB(1f, 0.8f, 0.01568628f);
    }
}
