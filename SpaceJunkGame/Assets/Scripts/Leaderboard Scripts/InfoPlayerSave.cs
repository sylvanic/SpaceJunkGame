using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;
using System.IO;

public class InfoPlayerSave : MonoBehaviour
{
    public static InfoPlayerSave instance;

    public TMP_InputField inputName;

    private string playerName;
    public string gender;
    public string ageGroup;

    private Button selectedAgeButton;
    private Button selectedGenderButton;

    private Color male, female, other;
    private Color child, teen, adult;

    public Color ageSelected = Color.blue;
    public Color genderSelected = Color.blue;
    private Color deselected = Color.white;

    public Button saveInfo;
    public Button cancelInfo;

    void Start()
    {
        Scene currentScene = SceneManager.GetActiveScene();
        string sceneName = currentScene.name;
        
        if (sceneName == "EndScreen")
        {
            inputName = inputName.GetComponent<TMP_InputField>();

            Button save = saveInfo.GetComponent<Button>();
            save.onClick.AddListener(SavePlayerInfo);

            Button cancel = cancelInfo.GetComponent<Button>();
            cancel.onClick.AddListener(CancelSave);
        }       
    }

    public void SavePlayerInfo()
    {
        PlayersInfo saveData = new PlayersInfo();

        if (!string.IsNullOrEmpty(inputName.text)){

            saveData.username = inputName.text;
            Debug.Log(saveData.username);

            saveData.highscore = PlayerPrefs.GetInt("Highscore");
            saveData.gender = gender;
            saveData.age = ageGroup;

            //string jsonInfo = PlayerPrefs.GetString("info");
            string jsonInfoCSV = File.ReadAllText(Application.dataPath + "/info.csv");
            Info information = JsonUtility.FromJson<Info>(jsonInfoCSV);

            if (information == null)
            {
                information = new Info()
                {
                    playersInfoList = new List<PlayersInfo>()
                };
            }

            information.playersInfoList.Add(saveData);

            string jsonAll = JsonUtility.ToJson(information);
            File.WriteAllText(Application.dataPath + "/info.csv", jsonAll);

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

    public void GenderSelected(Button button)
    {
        if (selectedGenderButton == button)
        {
            button.GetComponent<Image>().color = deselected;
            selectedGenderButton = null;
        }
        else
        {
            if (selectedGenderButton != null)
            {
                selectedGenderButton.GetComponent<Image>().color = deselected;
            }
            button.GetComponent<Image>().color = genderSelected;
            selectedGenderButton = button;
        }

        male = GameObject.Find("OptMale").GetComponent<Image>().color;
        female = GameObject.Find("OptFemale").GetComponent<Image>().color;
        other = GameObject.Find("OptOther").GetComponent<Image>().color;

        if (male == Color.blue)
        {
            gender = "male";
        }
        else if (female == Color.blue)
        {
            gender = "female";
        }
        else if (other == Color.blue)
        {
            gender = "other";
        }

        if (male == deselected && female == deselected && other == deselected)
        {
            gender = "";
        }
    }

    public void AgeGroupSelected(Button button)
    {
        if (selectedAgeButton == button)
        {
            button.GetComponent<Image>().color = deselected;
            selectedAgeButton = null;
        }
        else
        {
            if (selectedAgeButton != null)
            {
                selectedAgeButton.GetComponent<Image>().color = deselected;
            }
            button.GetComponent<Image>().color = ageSelected;
            selectedAgeButton = button;
        }

        child = GameObject.Find("OptChild").GetComponent<Image>().color;
        teen = GameObject.Find("OptTeen").GetComponent<Image>().color;
        adult = GameObject.Find("OptAdult").GetComponent<Image>().color;

        if (child == Color.blue)
        {
            ageGroup = "child";
        }
        else if (teen == Color.blue)
        {
            ageGroup = "teen";
        }
        else if (adult == Color.blue)
        {
            ageGroup = "adult";
        }

        if (child == deselected && teen == deselected && adult == deselected)
        {
            ageGroup = "";
        }
    }
    
    public void CancelSave()
    { 
        SceneManager.LoadScene("NEW_Menu");
        File.Delete(Application.dataPath + "/info.csv");
        Debug.Log("The CSV file was deleted, test leaderboard scene if there is no null");
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
