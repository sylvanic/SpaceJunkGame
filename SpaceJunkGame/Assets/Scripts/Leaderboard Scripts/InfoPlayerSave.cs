using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class InfoPlayerSave : MonoBehaviour
{
    public static InfoPlayerSave instance;

    public TMP_InputField inputName;
    public Button[] genderButtons;
    public Button[] ageButtons;

    private string playerName;
    public string gender;
    public string ageGroup;

    public Button saveInfo;
    public Button cancelInfo;

    void Start()
    {
        Scene currentScene = SceneManager.GetActiveScene();
        string sceneName = currentScene.name;

        if (sceneName == "EndScreen")
        {
            inputName = inputName.GetComponent<TMP_InputField>();

            for (int i = 0; i < genderButtons.Length; i++)
            {
                int closureIndex = i;
                genderButtons[closureIndex].onClick.AddListener(() => GenderOnClick(closureIndex));
            }

            for (int i = 0; i < ageButtons.Length; i++)
            {
                int closureIndex = i;
                ageButtons[closureIndex].onClick.AddListener(() => AgeOnClick(closureIndex));
            }

            Button save = saveInfo.GetComponent<Button>();
            save.onClick.AddListener(SavePlayerInfo);

            Button cancel = cancelInfo.GetComponent<Button>();
            cancel.onClick.AddListener(CancelSave);
        }
    }

    public void SavePlayerInfo()
    {
        PlayersInfo saveData = new PlayersInfo();

        if(!string.IsNullOrEmpty(inputName.text)){

            saveData.username = inputName.text;
            Debug.Log(saveData.username);

            saveData.highscore = PlayerPrefs.GetInt("Highscore");
            saveData.gender = gender;
            saveData.age = ageGroup;

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

            SceneManager.LoadScene("Leaderboard");
        } else {            
            if (saveData.username == "")
            {
                inputName.GetComponent<Outline>().enabled = true;                
            }
            else
            {
                inputName.GetComponent<Outline>().enabled = false;
            }
            Debug.Log("fill in your name");
        }                
    }

    public void GenderOnClick(int buttonIndex)
    {
        Debug.Log("You have clicked the button #" + buttonIndex, genderButtons[buttonIndex]);

        switch (buttonIndex)
        {
            case 0:
                gender = "Male";
                break;
            case 1:
                gender = "Female";
                break;
            case 2:
                gender = "Other";
                break;

        }
        Debug.Log(gender);
    }

    public void AgeOnClick(int buttonIndex)
    {
        Debug.Log("You have clicked the button #" + buttonIndex, ageButtons[buttonIndex]);


        switch (buttonIndex)
        {
            case 0:
                ageGroup = "Child";
                break;
            case 1:
                ageGroup = "Teen";
                break;
            case 2:
                ageGroup = "Adult";
                break;

        }
        Debug.Log(ageGroup);
    }

    public void CancelSave()
    {
        SceneManager.LoadScene("NEW_Menu");
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
        public string gender;
        public string age;
    }
}
