using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddPlayerScores : MonoBehaviour
{
    void Awake()
    {
        //AddScores(ScoreDisplay.score, DisplayPlayerName.playerUsername);
    }
    private void AddScores(int score, string name)
    {
        PlayerScore playerScore = new PlayerScore { score = score, name = name };

        string jsonString = PlayerPrefs.GetString("highscoreTable");
        Scores highscores = JsonUtility.FromJson<Scores>(jsonString);

        highscores.scoreList.Add(playerScore);

        string json = JsonUtility.ToJson(highscores);
        PlayerPrefs.SetString("highscoreTable", json);
        PlayerPrefs.Save();
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
