using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ScoreTask : Objective
{
    private int points;
    public int requiredPoints;

    public static string scoreTaskTxt;

    public TextMeshProUGUI scoreTask;

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
        scoreTask.text = string.Format(scoreTaskTxt + "{0}/{1}", points, requiredPoints);
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
        scoreTask.color = Color.yellow;  
    }
}
