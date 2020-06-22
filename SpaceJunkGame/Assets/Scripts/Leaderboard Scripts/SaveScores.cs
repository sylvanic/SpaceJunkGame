using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SaveScores : MonoBehaviour
{   
    public void Save()
    {
        AddSaveSceneScores();
    }

    public void AddSaveSceneScores()
    {
        Scene currentScene = SceneManager.GetActiveScene();
        string sceneName = currentScene.name;       

        if (sceneName == "Lvl1Cutscene")
        {
            PlayerScore1 playerScore = new PlayerScore1();

            playerScore.scoreLevel1 = PlayerStats.totalScore;
 
            PlayerPrefs.SetInt("level1Results", playerScore.scoreLevel1);
            PlayerPrefs.Save();
            Debug.Log(PlayerPrefs.GetInt("level1Results"));
        } 

        if (sceneName == "Lvl2Cutscene")
        {
            PlayerScore2 playerScore = new PlayerScore2();

            playerScore.scoreLevel2 = PlayerStats.totalScore;
           
            PlayerPrefs.SetInt("level2Results", playerScore.scoreLevel2);
            PlayerPrefs.Save();
            Debug.Log(PlayerPrefs.GetInt("level2Results"));
        }

        if (sceneName == "Lvl3Cutscene")
        {
            PlayerScore3 playerScore = new PlayerScore3();

            playerScore.scoreLevel3 = PlayerStats.totalScore;

            PlayerPrefs.SetInt("level3Results", playerScore.scoreLevel3);
            PlayerPrefs.Save();
            Debug.Log(PlayerPrefs.GetInt("level3Results"));
        }
    }

    private class ScoreList1
    {
        public List<PlayerScore1> scoreList1;       
    }

    private class ScoreList2
    {
        public List<PlayerScore2> scoreList2;
    }

    private class ScoreList3
    {
        public List<PlayerScore3> scoreList3;
    }

    [System.Serializable]
    private class PlayerScore1
    {
        public int scoreLevel1;       
    }

    [System.Serializable]
    private class PlayerScore2
    {
        public int scoreLevel2;
    }

    [System.Serializable]
    private class PlayerScore3
    {
        public int scoreLevel3;
    }

}
