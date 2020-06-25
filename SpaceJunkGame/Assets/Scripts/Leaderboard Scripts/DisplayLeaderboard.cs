using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;
using System.IO;

public class DisplayLeaderboard : MonoBehaviour
{
    //private float timer = 3600f;
    //public Text time;

    private Transform scoreContainer;
    private Transform playerTemplate;
    public GameObject panel;

    private List<Transform> playerScoreTransformList;

    void Start()
    {
        PlayerPrefs.GetInt("info", 0);
        PlayerPrefs.GetInt("SaveTime", 0);

        if (PlayerPrefs.HasKey("info") || File.Exists(Application.dataPath + "/info.csv"))
        {
            scoreContainer = transform.Find("Tab");
            playerTemplate = scoreContainer.Find("SecondTab");

            playerTemplate.gameObject.SetActive(false);

            //string jsonString = PlayerPrefs.GetString("info");
            string jsonCSV = File.ReadAllText(Application.dataPath + "/info.csv");
            Info list = JsonUtility.FromJson<Info>(jsonCSV);
            //Debug.Log(PlayerPrefs.GetString("info"));
            Debug.Log(File.ReadAllText(Application.dataPath + "/info.csv"));

            //Sort out the score
            for (int i = 0; i < list.playersInfoList.Count; i++)
            {
                for (int j = 0; j < list.playersInfoList.Count; j++)
                {
                    if (list.playersInfoList[i].highscore > list.playersInfoList[j].highscore)
                    {
                        PlayersInfo swap = list.playersInfoList[i];
                        list.playersInfoList[i] = list.playersInfoList[j];
                        list.playersInfoList[j] = swap;
                    }
                }
            }

            //Limit till 10
            if (list.playersInfoList.Count > 10)
            {
                for (int h = list.playersInfoList.Count; h > 10; h--)
                {
                    list.playersInfoList.RemoveAt(10);
                }
            }

            //Display the tab of players info
            playerScoreTransformList = new List<Transform>();
            foreach (PlayersInfo playerResults in list.playersInfoList)
            {
                CreatePlayersScoreTab(playerResults, scoreContainer, playerScoreTransformList);
            }
        }        
    }

    private void CreatePlayersScoreTab(PlayersInfo playerResults, Transform container, List<Transform> transformList)
    {
        float templateHeight = 50f;
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

        scoreTab.Find("rank").GetComponent<TMP_Text>().text = rankString;

        int score = playerResults.highscore;
        scoreTab.Find("score").GetComponent<TMP_Text>().text = score.ToString();

        string name = playerResults.username;
        scoreTab.Find("name").GetComponent<TMP_Text>().text = name;

        if (rank == 1)
        {
            scoreTab.Find("rank").GetComponent<TMP_Text>().color = new Color32(255, 214, 51, 255);
            scoreTab.Find("score").GetComponent<TMP_Text>().color = new Color32(255, 214, 51, 255);
            scoreTab.Find("name").GetComponent<TMP_Text>().color = new Color32(255, 214, 51, 255);
        }
        if (rank == 2)
        {
            scoreTab.Find("rank").GetComponent<TMP_Text>().color = new Color32(220, 220, 220, 255);
            scoreTab.Find("score").GetComponent<TMP_Text>().color = new Color32(220, 220, 220, 255);
            scoreTab.Find("name").GetComponent<TMP_Text>().color = new Color32(220, 220, 220, 255);
        }
        if (rank == 3)
        {
            scoreTab.Find("rank").GetComponent<TMP_Text>().color = new Color32(219, 167, 112, 255);
            scoreTab.Find("score").GetComponent<TMP_Text>().color = new Color32(219, 167, 112, 255);
            scoreTab.Find("name").GetComponent<TMP_Text>().color = new Color32(219, 167, 112, 255);
        }

        transformList.Add(scoreTab);
    }

    private void ClearAll()
    {
        //Load saved scores
        string json = PlayerPrefs.GetString("GameInfo");
        Info list = JsonUtility.FromJson<Info>(json);

        //Clear scores table
        list.playersInfoList.Clear();

        //Save updated scores
        string clearedList = JsonUtility.ToJson(list);
        PlayerPrefs.SetString("GameInfo", clearedList);
        PlayerPrefs.Save();
    }

    public void DeleteAllPlayerPrefs()
    {
        PlayerPrefs.DeleteAll();
    }

    private class Info
    {
        public List<PlayersInfo> playersInfoList;
    }

    [System.Serializable]
    private class PlayersInfo
    {
        public string username;
        public int highscore;
    }
}
