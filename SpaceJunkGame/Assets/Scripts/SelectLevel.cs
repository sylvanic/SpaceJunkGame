using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SelectLevel : MonoBehaviour
{
    public Button Level1, Level2, Level3;

    public void ChosenLevel()
    {
        Level1.onClick.AddListener(SelectLevel1);

        Level2.onClick.AddListener(SelectLevel2);

        Level3.onClick.AddListener(SelectLevel3);

    }
    
    private void SelectLevel1()
    {
        SceneManager.LoadScene("Intro");
    }

    private void SelectLevel2()
    {
        SceneManager.LoadScene("Level_2");
    }

    private void SelectLevel3()
    {
        SceneManager.LoadScene("Tutorial");
    }

    public void BackToMainMenu()
    {
        SceneManager.LoadScene("NEW_Menu");
    }
}