using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class SaveName : MonoBehaviour
{
    public TMP_InputField playersName;

    void Start()
    {
        playersName = playersName.GetComponent<TMP_InputField>();
    }

    private void AddPlayerInfo(string name)
    {      
        PlayerScore playerName = new PlayerScore
        {
            username = name
        };

        string jsonNames = PlayerPrefs.GetString("username");
        Scores names = JsonUtility.FromJson<Scores>(jsonNames);

        if (names == null)
        {
            names = new Scores()
            {
                nameList = new List<PlayerScore>()
            };
        }

        names.nameList.Add(playerName);

        string jsonNameData = JsonUtility.ToJson(names);
        PlayerPrefs.SetString("username", jsonNameData);
        PlayerPrefs.Save();
        Debug.Log(PlayerPrefs.GetString("username"));
    }

    public void BackMenu()
    {
        SceneManager.LoadScene(0);
    }

    public void LeaderboardScene()
    {        
        DisplayPlayerName.playerUsername = playersName.text;
        AddPlayerInfo(DisplayPlayerName.playerUsername);
        SceneManager.LoadScene(4);
    }

    private class Scores
    {
        public List<PlayerScore> nameList;
    }

    [System.Serializable]
    private class PlayerScore
    {
        public string username;
    }
}
