using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;

public class ResultScreens : MonoBehaviour
{
    public static bool checkChallengedCompleted = false;
    public int levelScoreMinimum = 50;
    public GameObject UpgradeBoard;
    public GameObject MissionCompleted;
    public GameObject checkChosenUpgrade;
    [Space]
    public Button[] buttons;

    public static string currentUpgrade;
    public static string currentUpgrade2;


    private void Start()
    {
        for (int i = 0; i < buttons.Length; i++)
        {
            int closureIndex = i; // Prevents the closure problem
            buttons[closureIndex].onClick.AddListener(() => TaskOnClick(closureIndex));
        }
    }

    public void CheckChallengeCompleted()
    {
        Debug.Log("clicked");

        if (PlayerStats.totalScore > levelScoreMinimum)    /// Mission Completed
        {
            if (checkChallengedCompleted == false)
            {
                SceneManager.LoadScene("SelectLevel");
            }
            else
            {
                UpgradeBoard.SetActive(true);      /// Challenge Completed
                MissionCompleted.SetActive(false);                         
            }
        }
        else            /// Mission Failed
        {
            if (SceneManager.GetActiveScene().name == "Lvl1Cutscene")
            {
                SceneManager.LoadScene("GameTest");
            }
            else if (SceneManager.GetActiveScene().name == "Lvl2Cutscene")
            {
                SceneManager.LoadScene("Level_2");
            }
            else if (SceneManager.GetActiveScene().name == "Lvl3Cutscene")
            {
                SceneManager.LoadScene("Level_3");
            }

        }
        

    }

    public void ShowEndScreen()
    {
        SceneManager.LoadScene("EndScreen");
    }

    public void CheckUpgradeSelected()
    {
        //if ((currentUpgrade == null || currentUpgrade == "") || (currentUpgrade2 == null || currentUpgrade2 == ""))
       //{
        //    checkChosenUpgrade.SetActive(true);
        //}
       // else
       // {
            if (SceneManager.GetActiveScene().name == "Lvl1Cutscene")
            {
                PlayerPrefs.SetString("ChosenUpgrade", currentUpgrade);
            }
            else if (SceneManager.GetActiveScene().name == "Lvl2Cutscene")
            {
                PlayerPrefs.SetString("ChosenUpgrade2", currentUpgrade2);
            }
          
            checkChosenUpgrade.SetActive(false);
            SceneManager.LoadScene("SelectLevel");
       // }
    }


    public void TaskOnClick(int buttonIndex)
    {
        Debug.Log("You have clicked the button #" + buttonIndex, buttons[buttonIndex]);

        if (SceneManager.GetActiveScene().name == "Lvl1Cutscene")
        {
            switch (buttonIndex)
            {
                case 0:
                    currentUpgrade = "booster";
                    break;
                case 1:
                    currentUpgrade = "weapon";
                    break;
                case 2:
                    currentUpgrade = "capacity";
                    break;
                case 3:
                    currentUpgrade = "shield";
                    break;
            }
        }
        
        if (SceneManager.GetActiveScene().name == "Lvl2Cutscene")
        {
            switch (buttonIndex)
            {
                case 0:
                    currentUpgrade2 = "booster";
                    break;
                case 1:
                    currentUpgrade2 = "weapon";
                    break;
                case 2:
                    currentUpgrade2 = "capacity";
                    break;
                case 3:
                    currentUpgrade2 = "shield";
                    break;
            }
        }

        //Debug.Log("currentUpgrade1" + currentUpgrade);
        //Debug.Log("currentUpgrade2" + currentUpgrade2);
    }

    private class ScoreList1
    {
        public List<PlayerScore1> scoreList1;
    }

    [System.Serializable]
    private class PlayerScore1
    {
        public int score1;
    }

    private class ScoreList2
    {
        public List<PlayerScore2> scoreList2;
    }

    [System.Serializable]
    private class PlayerScore2
    {
        public int score2;
    }

    private class ScoreList3
    {
        public List<PlayerScore3> scoreList3;
    }

    [System.Serializable]
    private class PlayerScore3
    {
        public int score3;
    }
}
