using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUpTask : Objective
{

    private int junk;
    public int requiredJunk;

    public static string pickUpTaskTxt;

    public GUIStyle guiStyle = new GUIStyle();

    private void Awake()
    {
        if (LangSwitchBool.englishTxt)
        {
            pickUpTaskTxt = "Collect junk: ";
        }
        else
        {
            pickUpTaskTxt = "Verzamel afval: ";
        }

        guiStyle.normal.textColor = Color.white;
        guiStyle.fontSize = 25;
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
        guiStyle.normal.textColor = Color.yellow;
    }

    public override void DrawHUD()
    {
        GUI.Label(new Rect(1565, 285, 300, 100), string.Format(pickUpTaskTxt + "{0}/{1}", junk, requiredJunk), guiStyle);
    }
}
