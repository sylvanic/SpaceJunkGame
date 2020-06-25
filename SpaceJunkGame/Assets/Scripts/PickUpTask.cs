using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class PickUpTask : Objective
{

    private int junk;
    public int requiredJunk;

    public static string pickUpTaskTxt;

    public TextMeshProUGUI pickUpTask;

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
    }

    private void Update()
    {
        pickUpTask.text = string.Format(pickUpTaskTxt + "{0}/{1}", junk, requiredJunk);
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
        pickUpTask.color = Color.yellow;
    }

}
