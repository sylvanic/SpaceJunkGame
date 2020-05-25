using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;
using UnityEditor;

public class MainMenu : MonoBehaviour
{

    [Header("Player Data")]
    [Space]
    public string playerName;

    [Space]
    public TMP_InputField playerNameInputField;

    Button selectedAgeButton;
    Button selectedGenderButton;

    Color blueColor = Color.blue;
    Color whiteColor = Color.white;

    private void Start()
    {
        
    }

    public void PlayGame()
    {
        playerName = playerNameInputField.text;

        if (playerName == "Shauntae")
        {
            Debug.Log("welcome to game");
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
        else
        {
            Debug.Log("fill in your name");
        }

        Debug.Log(playerName);
    }

    public void QuitGame()
    {
        Debug.Log("quit");
        Application.Quit();
    }

    public void AgeGroupSelected(Button button)
    {
        if (selectedAgeButton == button )
        {
            button.GetComponent<Image>().color = whiteColor;
            selectedAgeButton = null;
        }
        else
        {
            if (selectedAgeButton != null)
            {
                selectedAgeButton.GetComponent<Image>().color = whiteColor;
            }
            button.GetComponent<Image>().color = blueColor;
            selectedAgeButton = button;
        }
    }

    public void GenderSelected(Button button)
    {
        if (selectedGenderButton == button)
        {
            button.GetComponent<Image>().color = whiteColor;
            selectedAgeButton = null;
        }
        else
        {
            if (selectedGenderButton != null)
            {
                selectedGenderButton.GetComponent<Image>().color = whiteColor;
            }
            button.GetComponent<Image>().color = blueColor;
            selectedGenderButton = button;
        }
    }
}
