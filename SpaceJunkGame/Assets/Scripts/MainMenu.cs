using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;


public class MainMenu : MonoBehaviour
{
    [Header("Player Data")]
    public string playerName;
    public string gender;
    public string ageGroup;
    [Space]
    public TMP_InputField playerNameInputField;
    public Button[] genderButtons;
    public Button[] ageButtons;

    private SoundManager soundManager;

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

    public void PlayGame()
    {

        playerName = playerNameInputField.text;

        PlayerPrefs.SetString("PlayerName", playerName);
        PlayerPrefs.SetString("PlayerGender", gender);
        PlayerPrefs.SetString("PlayerAge", ageGroup);

        SceneManager.LoadScene("Intro");

        /*
        if ((playerName != "") &&                                                   ///Checks if all player data has been filled in 
            (gender == "male" || gender == "female" || gender == "other") && 
            (ageGroup == "child" || ageGroup == "teen" || ageGroup == "adult"))
        {
       
        }
        else
        {
            Debug.Log("fill in your name");
            CheckInputs();                      ///Red outline around box when field isn't filled in 
        }
        */
        
    }
    
    public void QuitGame()
    {
        Debug.Log("quit");
        Application.Quit();
    }

    public void CheckInputs()
    {
        if (playerName == "")
        {
            playerNameInputField.GetComponent<Outline>().enabled = true;
        }
        else
        {
            playerNameInputField.GetComponent<Outline>().enabled = false;
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
