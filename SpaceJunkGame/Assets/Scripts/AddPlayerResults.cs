using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.IO;

public class AddPlayerResults : MonoBehaviour
{ 
    void Awake()
    {
        //AddPlayerScores(ScoreDisplay.score, DisplayPlayerName.playerUsername);        
    }

    private void AddPlayerScores(int score, string name)
    {
        PlayerScore playerScore = new PlayerScore { score = score, name = name };

        string jsonString = PlayerPrefs.GetString("leaderboard");
        Scores highscores = JsonUtility.FromJson<Scores>(jsonString);

        if (highscores == null)
        {
            // There's no stored table, initialize
            highscores = new Scores()
            {
                scoreList = new List<PlayerScore>()
            };
        }

        highscores.scoreList.Add(playerScore);

        string json = JsonUtility.ToJson(highscores);
        PlayerPrefs.SetString("leaderboard", json);
        PlayerPrefs.Save();
        Debug.Log(PlayerPrefs.GetString("leaderboard"));
    }

    private class Scores
    {
        public List<PlayerScore> scoreList;
    }

    [System.Serializable]
    private class PlayerScore
    {
        public int score;
        public string name;
    }
}
