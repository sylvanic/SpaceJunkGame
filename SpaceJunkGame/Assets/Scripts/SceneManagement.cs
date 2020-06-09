using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SceneManagement : MonoBehaviour
{

    public void ReturnToMainMenu()
    {
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
