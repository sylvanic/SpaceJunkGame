using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.IO;

public class SceneManagement : MonoBehaviour
{
    private SaveInfo saveinfo;

    private void Awake()
    {
        saveinfo = GameObject.FindGameObjectWithTag("SaveInfo").GetComponent<SaveInfo>();

        if (!File.Exists(Application.dataPath + "/info.csv"))
        {                      
            Debug.Log("The .csv file doesn't exist at the moment.");
        } else
        {
            Debug.Log("The .csv file has been created.");
        }
    }

    public void ReturnToMainMenu()
    {
        saveinfo.ResetSaves();
        Time.timeScale = 1;
        SceneManager.LoadScene("NEW_Menu");
    }

    public void BackMainMenu()
    {
        SceneManager.LoadScene("NEW_Menu");
    }

    public void EnterUsernameScene()
    {
        SceneManager.LoadScene("Username");
    }

    public void IntroFamiliarityYes()
    {
        SceneManager.LoadScene("Tutorial");
    }

    public void SelectLevel()
    {
        SceneManager.LoadScene("SelectLevel");
    }

    public void LeaderBoard(){       
        SceneManager.LoadScene("Leaderboard");
    }

    public void ResetLeaderboard()
    {
        PlayerPrefs.DeleteKey("ScoreLevel1");
        PlayerPrefs.DeleteKey("ScoreLevel2");
        PlayerPrefs.DeleteKey("ScoreLevel3");
        PlayerPrefs.DeleteKey("Highscore");
        PlayerPrefs.DeleteKey("info");
        File.Delete(Application.dataPath + "/info.csv");
        File.Delete(Application.dataPath + "/GameInfo.csv");
        SceneManager.LoadScene("Leaderboard");
    }

    public void StartIntro()
    {
        SceneManager.LoadScene("Intro");
    }
}
