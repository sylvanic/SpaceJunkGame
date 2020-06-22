using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class InfoPlayerSave : MonoBehaviour
{
    public static InfoPlayerSave instance;

    void Awake()
    {
        Scene currentScene = SceneManager.GetActiveScene();
        string sceneName = currentScene.name;
        
        if(sceneName == "Leaderboard")
        {
            SavePlayerInfo();
        }        
    }

    public void SavePlayerInfo()
    {
        PlayersInfo saveData = new PlayersInfo();

        saveData.username = DisplayPlayerName.playerUsername;
        Debug.Log(saveData.username);
        saveData.highscore = PlayerPrefs.GetInt("highscore");
        Debug.Log(saveData.highscore);

        string jsonInfo = PlayerPrefs.GetString("info");
        Info information = JsonUtility.FromJson<Info>(jsonInfo);

        if (information == null)
        {
            information = new Info()
            {
                playersInfoList = new List<PlayersInfo>()
            };
        }

        information.playersInfoList.Add(saveData);

        string jsonAll = JsonUtility.ToJson(information);
        PlayerPrefs.SetString("info", jsonAll);
        PlayerPrefs.Save();        
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
