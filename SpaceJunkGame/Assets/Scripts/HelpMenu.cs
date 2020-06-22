using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HelpMenu : MonoBehaviour
{
    public GameObject HintButton;
    public GameObject exitButton;
    public GameObject MenuPage1;
    public GameObject MenuPage2;
    public GameObject MenuPage3;

    public void CloseMenu()
    {
        exitButton.SetActive(false);
        MenuPage1.SetActive(false);
        MenuPage2.SetActive(false);
        MenuPage3.SetActive(false);
    }

    public void OpenMenu()
    {
        exitButton.SetActive(true);
        MenuPage1.SetActive(true);
    }

    public void GoToPage1fromPage2()
    {
        MenuPage2.SetActive(true);
        MenuPage1.SetActive(false);
    }

    public void GoToPage2fromPage1()
    {
        MenuPage2.SetActive(false);
        MenuPage1.SetActive(true);
    }

    public void GoToPage3fromPage2()
    {
        MenuPage3.SetActive(false);
        MenuPage2.SetActive(true);
    }

    public void GoToPage2fromPage3()
    {
        MenuPage3.SetActive(true);
        MenuPage2.SetActive(false);
    }
}
