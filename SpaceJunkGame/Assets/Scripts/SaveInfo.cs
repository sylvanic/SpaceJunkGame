using System.CodeDom;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SaveInfo : MonoBehaviour
{
    public static SaveInfo Instance;


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
        // Debug.Log("Level 1: " + loadedData.scoreLevel1 + "Level 2: " + loadedData.scoreLevel2 + "Level 3: " + loadedData.scoreLevel3);
        // Debug.Log("Highscore:" + loadedData.highscore);
        // Debug.Log("name: " + loadedData.playerName + "gender: " + loadedData.playerGender + "age: " + loadedData.playerAge);

        // Debug.Log("chosen upgrade: " + loadedData.chosenUpgrade);

       // Debug.Log("booster" + loadedData.HasBooster + "weapon" + loadedData.HasWeapon + "capacity" + loadedData.HasCapacity + "shield" + loadedData.HasShield);

       // Debug.Log("booster2" + loadedData.HasBooster2 + "weapon2" + loadedData.HasWeapon2 + "capacity2" + loadedData.HasCapacity2 + "shield2" + loadedData.HasShield2);

    }

    public void ResetSaves()
    {
        PlayerPrefs.DeleteAll();
    }

}
