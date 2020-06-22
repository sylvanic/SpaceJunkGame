using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class SaveName : MonoBehaviour
{
    private string playerName;

    public TMP_InputField playersName;

    public void AddPlayerInfo()
    {
        playerName = playersName.text;

        PlayerPrefs.SetString("PlayerName", playerName);
        Debug.Log(PlayerPrefs.GetString("PlayerName"));

        SceneManager.LoadScene("Leaderboard");
    }
}
