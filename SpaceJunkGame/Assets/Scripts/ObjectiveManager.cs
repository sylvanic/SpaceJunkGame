using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectiveManager : MonoBehaviour
{
    public Objective[] objective;
    public static GUIStyle guiStyle = new GUIStyle();
    //Font myFont = (Font)Resources.Load("Fonts/Oxanium-Regular SDF", typeof(Font));

    private void Awake()
    {
        objective = GetComponents<Objective>();
    }

    private void OnGUI()
    {
        guiStyle.normal.textColor = Color.white;
        guiStyle.fontSize = 25;

        foreach (var objective in objective)
        {
            objective.DrawHUD();
        }
    }

    private void Update()
    {
        foreach (var objective in objective)
        {
            if (objective.IsComplete())
            {
                objective.Complete();
            }
        }
    }
}

