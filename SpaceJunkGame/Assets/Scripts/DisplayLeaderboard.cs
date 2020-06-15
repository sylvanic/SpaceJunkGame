using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DisplayLeaderboard : MonoBehaviour
{
    private Transform scoreContainer;
    private Transform playerTemplate;

    private List<Transform> playerScoreTransformList;   

    void Awake()
    {
        PlayerPrefs.GetInt("leaderboard", 0);

        if (PlayerPrefs.HasKey("leaderboard"))
        {
            scoreContainer = transform.Find("Tab");
            playerTemplate = scoreContainer.Find("SecondTab");

            playerTemplate.gameObject.SetActive(false);

            //clearScoreTable();

            string jsonString = PlayerPrefs.GetString("leaderboard");
            Scores highscores = JsonUtility.FromJson<Scores>(jsonString);

            //Sort out the score
            for (int i = 0; i < highscores.scoreList.Count; i++)
            {
                for (int j = 0; j < highscores.scoreList.Count; j++)
                {
                    if (highscores.scoreList[i].score > highscores.scoreList[j].score)
                    {
                        PlayerScore swap = highscores.scoreList[i];
                        highscores.scoreList[i] = highscores.scoreList[j];
                        highscores.scoreList[j] = swap;
                    }
                }
            }

            //Limit till 10
            if (highscores.scoreList.Count > 10)
            {
                for (int h = highscores.scoreList.Count; h > 10; h--)
                {
                    highscores.scoreList.RemoveAt(10);
                }
            }

            //Display the tab of players info
            playerScoreTransformList = new List<Transform>();
            foreach (PlayerScore playerScore in highscores.scoreList)
            {
                CreatePlayersScoreTab(playerScore, scoreContainer, playerScoreTransformList);
            }
        }
    }  

    private void CreatePlayersScoreTab(PlayerScore playerScore, Transform container, List<Transform> transformList)
    {
        float templateHeight = 30f;
        Transform scoreTab = Instantiate(playerTemplate, container);
        RectTransform scoreTabTransform = scoreTab.GetComponent<RectTransform>();
        scoreTabTransform.anchoredPosition = new Vector2(0, -templateHeight * transformList.Count);
        scoreTab.gameObject.SetActive(true);

        int rank = transformList.Count + 1;
        string rankString;
        switch (rank)
        {
            default: rankString = rank + "TH";
                scoreTab.Find("gold").gameObject.SetActive(false);
                scoreTab.Find("silver").gameObject.SetActive(false);
                scoreTab.Find("bronze").gameObject.SetActive(false);
                break;
            case 1: rankString = "1ST";
                scoreTab.Find("gold").GetComponent<Image>();
                scoreTab.Find("silver").gameObject.SetActive(false);
                scoreTab.Find("bronze").gameObject.SetActive(false);
                break;
            case 2: rankString = "2ND";
                scoreTab.Find("silver").GetComponent<Image>();
                scoreTab.Find("gold").gameObject.SetActive(false);
                scoreTab.Find("bronze").gameObject.SetActive(false);
                break;
            case 3: rankString = "3RD";
                scoreTab.Find("bronze").GetComponent<Image>();
                scoreTab.Find("gold").gameObject.SetActive(false);
                scoreTab.Find("silver").gameObject.SetActive(false);
                break;
        }

        scoreTab.Find("rank").GetComponent<Text>().text = rankString;

        int score = playerScore.score;
        scoreTab.Find("score").GetComponent<Text>().text = score.ToString();

        string name = playerScore.name;
        scoreTab.Find("name").GetComponent<Text>().text = name;

        if (rank == 1)
        {
            scoreTab.Find("rank").GetComponent<Text>().color = new Color32(255, 214, 51, 255);
            scoreTab.Find("score").GetComponent<Text>().color = new Color32(255, 214, 51, 255);
            scoreTab.Find("name").GetComponent<Text>().color = new Color32(255, 214, 51, 255);
        }
        if (rank == 2)
        {
            scoreTab.Find("rank").GetComponent<Text>().color = new Color32(220, 220, 220, 255);
            scoreTab.Find("score").GetComponent<Text>().color = new Color32(220, 220, 220, 255);
            scoreTab.Find("name").GetComponent<Text>().color = new Color32(220, 220, 220, 255);
        }
        if (rank == 3)
        {
            scoreTab.Find("rank").GetComponent<Text>().color = new Color32(219, 167, 112, 255);
            scoreTab.Find("score").GetComponent<Text>().color = new Color32(219, 167, 112, 255);
            scoreTab.Find("name").GetComponent<Text>().color = new Color32(219, 167, 112, 255);
        }

        transformList.Add(scoreTab);
    }

    private void clearScoreTable()
    {
        //Load saved scores
        string jsonString = PlayerPrefs.GetString("leaderboard");
        Scores highscores = JsonUtility.FromJson<Scores>(jsonString);

        //Clear scores table
        highscores.scoreList.Clear();

        //Save updated scores
        string json = JsonUtility.ToJson(highscores);
        PlayerPrefs.SetString("leaderboard", json);
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
