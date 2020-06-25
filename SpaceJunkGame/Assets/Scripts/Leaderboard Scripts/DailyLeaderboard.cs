using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.IO;
using TMPro;

public class DailyLeaderboard : MonoBehaviour
{
    static private float msToWait = 420000.0f;//86400000.0f

    private ulong lastUpdateList;
    public TMP_Text timeText;

    void Start()
    {
        if (!PlayerPrefs.HasKey("SaveTime"))
        {
            PlayerPrefs.SetString("SaveTime", lastUpdateList.ToString());
        }
        else
        {
            lastUpdateList = ulong.Parse(PlayerPrefs.GetString("SaveTime"));
        }

        timeText = timeText.GetComponent<TMP_Text>();
    }

    void Update()
    {
        if (!PlayerPrefs.HasKey("SaveTime") || PlayerPrefs.HasKey("SaveTime"))
        {
            if (IsTimeUpdated())
            {
                lastUpdateList = (ulong)DateTime.Now.Ticks;
                PlayerPrefs.SetString("SaveTime", lastUpdateList.ToString());
                PlayerPrefs.DeleteKey("info");
                File.Delete(Application.dataPath + "/info.csv");
                PlayerPrefs.DeleteKey("ScoreLevel1");
                PlayerPrefs.DeleteKey("ScoreLevel2");
                PlayerPrefs.DeleteKey("ScoreLevel3");
                PlayerPrefs.DeleteKey("Highscore");
                PlayerPrefs.DeleteKey("GameInfo");
                SceneManager.LoadScene("Leaderboard");
                Debug.Log("Updated time is saved!");
                return;
            }

            //Set the timer
            ulong diff = ((ulong)DateTime.Now.Ticks - lastUpdateList);
            ulong m = diff / TimeSpan.TicksPerMillisecond;
            float secondsLeft = (float)(msToWait - m) / 1000.0f;

            string r = "";
            // Hours
            r += ((int)secondsLeft / 3600).ToString("00") + " : ";
            secondsLeft -= ((int)secondsLeft / 3600) * 3600;
            //Minutes
            r += ((int)secondsLeft / 60).ToString("00") + " : ";
            //Seconds
            r += (secondsLeft % 60).ToString("00");
            timeText.text = r;
        }
    }

    private bool IsTimeUpdated()
    {
        ulong diff = ((ulong)DateTime.Now.Ticks - lastUpdateList);
        ulong m = diff / TimeSpan.TicksPerMillisecond;

        float secondsLeft = (float)(msToWait - m) / 1000.0f;
        //Debug.Log(secondsLeft);

        if (secondsLeft < 0)
        {
            return true;
        }
        return false;
    }
}

