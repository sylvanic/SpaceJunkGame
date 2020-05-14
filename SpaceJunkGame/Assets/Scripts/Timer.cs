using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    float currentTime = 0f;
    float startingTime = 120f;

    [SerializeField] Text countdownText;

    void Start ()
    {
        currentTime = startingTime;
    }

    void Update()
    {
        currentTime -= 1f * Time.deltaTime;

        countdownText.text = "Timer: " + currentTime.ToString("0");

        
        if (currentTime <= 5)
        {
            countdownText.color = Color.red;
        }
        
        if (currentTime <= 0)
        {
            currentTime = 0;
        }
    }
}
