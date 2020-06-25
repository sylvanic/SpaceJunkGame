using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ObjectiveManager : MonoBehaviour
{
    public Objective[] objective;

    private void Awake()
    {
        objective = GetComponents<Objective>();


        if (SceneManager.GetActiveScene().name == "GameTest" || SceneManager.GetActiveScene().name == "Level_2" || SceneManager.GetActiveScene().name == "Level_3")
        {
            PlayerStats.hitAmount = 0;
            PlayerStats.totalScore = 0;
            Pickable.junkAmount = 0;
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

