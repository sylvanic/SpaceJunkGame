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
    private SoundManager soundManager;

    private Button selectedAgeButton;
    private Button selectedGenderButton;

    private Color male, female, other;
    private Color child, teen, adult;

    private Color ageSelected = Color.blue;
    private Color genderSelected = Color.blue;
    private Color deselected = Color.white;

    private void Awake()
    {
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
}
