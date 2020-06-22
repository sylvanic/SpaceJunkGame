using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SceneManagement : MonoBehaviour
{
    private SaveInfo saveinfo;

    private void Awake()
    {
        //saveinfo = GameObject.FindGameObjectWithTag("SaveInfo").GetComponent<SaveInfo>();
    }

    public void ReturnToMainMenu()
    {
        saveinfo.ResetSaves();
        Time.timeScale = 1;
        SceneManager.LoadScene("NEW_Menu");
    }

    public void IntroFamiliarityYes()
    {
        SceneManager.LoadScene("Tutorial");
    }

    public void SelectLevel()
    {
        SceneManager.LoadScene("SelectLevel");
    }
}
