using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SaveHighscore : MonoBehaviour
{
    public static int highscore;

    public int score1;
    public int score2;  

    void Awake()
    {
        Scene currentScene = SceneManager.GetActiveScene();
        string sceneName = currentScene.name;

        if(sceneName == "EnterName")
        {
            HighscoreCount();
        }       
    }
  
    public void HighscoreCount()
    {
        PlayerScore1 ph1 = new PlayerScore1();
        ph1.scoreLevel1 = PlayerPrefs.GetInt("level1Results");
        Debug.Log(ph1.scoreLevel1 + " level 1 score");

        PlayerScore2 ph2 = new PlayerScore2();
        ph2.scoreLevel2 = PlayerPrefs.GetInt("level2Results");
        Debug.Log(ph2.scoreLevel2 + " level 2 score");

        PlayerHighscore ph = new PlayerHighscore();
        ph.highscore = ph1.scoreLevel1 + ph2.scoreLevel2;

        PlayerPrefs.SetInt("highscore", ph.highscore);
        PlayerPrefs.Save();
        Debug.Log(ph.highscore + " the overall");
    }

    private class HighscoreList
    {
        public List<PlayerHighscore> highscoreList;
    }
  
    [System.Serializable]
    private class PlayerHighscore
    {       
        public int highscore;
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

}