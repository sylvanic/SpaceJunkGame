﻿using System.CodeDom;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;
using System.IO;

public class SaveInfo : MonoBehaviour
{
    public static SaveInfo Instance;

    private ulong lastUpdateList;

    private void Update()
    {
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

        PlayerPrefs.SetInt("Highscore", saveData.highscore);

        saveData.chosenUpgrade = PlayerPrefs.GetString("ChosenUpgrade");
        saveData.chosenUpgrade2 = PlayerPrefs.GetString("ChosenUpgrade2");

        saveData.HasBooster = PlayerPrefs.GetInt("HasBooster");
        saveData.HasWeapon = PlayerPrefs.GetInt("HasWeapon");
        saveData.HasCapacity = PlayerPrefs.GetInt("HasCapacity");
        saveData.HasShield = PlayerPrefs.GetInt("HasShield");

        saveData.HasBooster2 = PlayerPrefs.GetInt("HasBooster2");
        saveData.HasWeapon2 = PlayerPrefs.GetInt("HasWeapon2");
        saveData.HasCapacity2 = PlayerPrefs.GetInt("HasCapacity2");
        saveData.HasShield2 = PlayerPrefs.GetInt("HasShield2");

        saveData.playerName = PlayerPrefs.GetString("PlayerName");       
        saveData.playerGender = PlayerPrefs.GetString("PlayerGender");
        saveData.playerAge = PlayerPrefs.GetString("PlayerAge");     

        //Convert to Json
        string jsonData = JsonUtility.ToJson(saveData);
        //Save in .CSV file
        File.WriteAllText(Application.dataPath + "/GameInfo.csv", jsonData);
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
    }

    public void ResetSaves()
    {
        PlayerPrefs.DeleteKey("ScoreLevel1");
        PlayerPrefs.DeleteKey("ScoreLevel2");
        PlayerPrefs.DeleteKey("ScoreLevel2");
        PlayerPrefs.DeleteKey("Highscore");
        PlayerPrefs.DeleteKey("GameInfo");
        ResultScreens.currentUpgrade = null;
        ResultScreens.currentUpgrade2 = null;
    }
}
