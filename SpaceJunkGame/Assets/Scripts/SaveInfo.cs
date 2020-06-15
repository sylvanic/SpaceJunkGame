using System.CodeDom;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class SaveInfo : MonoBehaviour
{
    public static SaveInfo Instance;

    private void Update()
    {
        // SomeScore();
        Save();
        Load();
    }

    private void Awake()
    {
        if (Instance == false)
        {
            Instance = this;
        }
        else
        {
            Destroy(this.gameObject);
        }
        DontDestroyOnLoad(this);
    }

    private void Save()
    {
        Save saveData = new Save();
        saveData.scoreLevel1 = PlayerPrefs.GetInt("ScoreLevel1");
        saveData.scoreLevel2 = PlayerPrefs.GetInt("ScoreLevel2");
        saveData.scoreLevel3 = PlayerPrefs.GetInt("ScoreLevel3");

        saveData.highscore = saveData.scoreLevel1 + saveData.scoreLevel2 + saveData.scoreLevel3;

        saveData.chosenUpgrade = PlayerPrefs.GetString("ChosenUpgrade");

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

    public void ResetSaves()
    {
        PlayerPrefs.DeleteAll();
    }
}
