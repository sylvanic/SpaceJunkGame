using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUpTask : Objective
{

    private int junk;
    public int requiredJunk;
    public static string pickUpTaskTxt;

    private void Awake()
    {
        if (LangSwitchBool.englishTxt)
        {
            pickUpTaskTxt = "Collected { 0}/{ 1} junk";
        }
        else
        {
            pickUpTaskTxt = "Verzamel {0}/{1} afval";
        }
    }

    private void Update()
    {
        junk = Pickable.junkAmount;

        if (junk >= requiredJunk)
        {
            junk = requiredJunk;
        }
    }

    public override bool IsComplete()
    {  
        return (junk >= requiredJunk);
    }

    public override void Complete()
    {
    }

    public override void DrawHUD()
    {
             GUI.Label(new Rect(1565, 285, 300, 100),string.Format(pickUpTaskTxt, junk, requiredJunk), ObjectiveManager.guiStyle);
    }
}
