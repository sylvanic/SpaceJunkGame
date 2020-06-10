using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUpTask : Objective
{

    private int junk;
    public int requiredJunk;

    private void Update()
    {
        //junk = Pickable.junkAmount;
    }

    public override bool IsComplete()
    {
        if (junk >= requiredJunk)
        {
            junk = requiredJunk;
        }
        return (junk >= requiredJunk);
    }

    public override void Complete()
    {
    }

    public override void DrawHUD()
    {
             GUI.Label(new Rect(1565, 285, 300, 100),string.Format("Collected {0}/{1} junk", junk, requiredJunk), ObjectiveManager.guiStyle);
    }
}
