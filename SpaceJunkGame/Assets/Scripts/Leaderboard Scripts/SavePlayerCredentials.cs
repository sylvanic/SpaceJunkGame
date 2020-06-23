using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class SavePlayerCredentials : MonoBehaviour
{
    public TMP_InputField inputName;
    public Button[] genderButtons;
    public Button[] ageButtons;

    public string playerName;
    public string gender;
    public string ageGroup;

    public int highscore;

    private void Start()
    {
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
    }

    public void AddPlayerInfo()
    {
       
        ///Checks if all player data has been filled in 
        if (!string.IsNullOrEmpty(inputName.text))
        {
            playerName = inputName.text;

            PlayerPrefs.SetString("PlayerName", playerName);
            PlayerPrefs.SetString("PlayerGender", gender);
            PlayerPrefs.SetString("PlayerAge", ageGroup);           

            SceneManager.LoadScene("Leaderboard");
        }
        else
        {
            Debug.Log("fill in your name");
            CheckInputs();                      ///Red outline around box when field isn't filled in 
        }       
    }

    public void CheckInputs()
    {
        if (playerName == "")
        {
            inputName.GetComponent<Outline>().enabled = true;
        }
        else
        {
            inputName.GetComponent<Outline>().enabled = false;
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
}
