using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SaveHighscore : MonoBehaviour
{
    public Button saveHighscore;

    void Start()
    {
        Button btn = saveHighscore.GetComponent<Button>();
        btn.onClick.AddListener(HighscoreCount);

        /*Scene currentScene = SceneManager.GetActiveScene();
        string sceneName = currentScene.name;

        if(sceneName == "EndScreen")
        {
            HighscoreCount();
        } */      
    }
  
    public void HighscoreCount()
    {
        PlayerScore1 ph1 = new PlayerScore1();
        ph1.scoreLevel1 = PlayerPrefs.GetInt("ScoreLevel1");
        Debug.Log(ph1.scoreLevel1 + " level 1 score");

        PlayerScore2 ph2 = new PlayerScore2();
        ph2.scoreLevel2 = PlayerPrefs.GetInt("ScoreLevel2");
        Debug.Log(ph2.scoreLevel2 + " level 2 score");

        PlayerScore3 ph3 = new PlayerScore3();
        ph3.scoreLevel3 = PlayerPrefs.GetInt("ScoreLevel3");
        Debug.Log(ph3.scoreLevel3 + " level 3 score");

        PlayerHighscore ph = new PlayerHighscore();
        ph.highscore = ph1.scoreLevel1 + ph2.scoreLevel2 + ph3.scoreLevel3;

        PlayerPrefs.SetInt("Highscore", ph.highscore);
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

    [System.Serializable]
    private class PlayerScore3
    {
        public int scoreLevel3;
    }
}