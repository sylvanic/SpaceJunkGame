using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SaveInfo : MonoBehaviour
{
    int lvl1 = 34;
    int lvl2 = 44;
    int lvl3 = 102;

    float time = 30f;

    private void Update()
    {
        // SomeScore();
        Save();
        Load();

        time -= 1 * Time.deltaTime;

        Debug.Log("time " + time);
    }

    private void SomeScore()
    {
        PlayerPrefs.SetInt("ScoreLevel1", lvl1);
        PlayerPrefs.SetInt("ScoreLevel2", lvl2);
        PlayerPrefs.SetInt("ScoreLevel3", lvl3);
    }

    private void Save()
    {
        Save saveData = new Save();
        saveData.scoreLevel1 = PlayerPrefs.GetInt("ScoreLevel1");
        saveData.scoreLevel2 = PlayerPrefs.GetInt("ScoreLevel2");
        saveData.scoreLevel3 = PlayerPrefs.GetInt("ScoreLevel3");

        saveData.highscore = saveData.scoreLevel1 + saveData.scoreLevel2 + saveData.scoreLevel3;

        //Convert to Json
        string jsonData = JsonUtility.ToJson(saveData);
        //Save Json string
        PlayerPrefs.SetString("GameInfo", jsonData);
        PlayerPrefs.Save();
    }

    private void Load()
    {
        //Load saved Json
        string jsonData = PlayerPrefs.GetString("GameInfo");
        //Convert to Class
        Save loadedData = JsonUtility.FromJson<Save>(jsonData);


        //Display saved data 
        Debug.Log("Level 1: " + loadedData.scoreLevel1 + "Level 2: " + loadedData.scoreLevel2 + "Level 3: " +
            loadedData.scoreLevel3);
        Debug.Log("Highscore:" + loadedData.highscore);


    }
}
