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
        //File.WriteAllText(Application.dataPath + "/info.csv", "");
        //Debug.Log(".csv file created!");  
        if (!File.Exists(Application.dataPath + "/info.csv"))
        {
            //File.WriteAllText(Application.dataPath + "/info.csv", "");
            Debug.Log("The deleted info.csv has been created again!");
        }
    }

    void Update()
    {        
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
        PlayerPrefs.DeleteKey("info");
        File.Delete(Application.dataPath + "/info.csv");
        SceneManager.LoadScene("Leaderboard");
    }

    public void StartIntro()
    {
        SceneManager.LoadScene("Intro");
    }
}
