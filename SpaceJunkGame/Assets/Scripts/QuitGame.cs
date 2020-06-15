using System.Collections;
using System.Collections.Generic;
using System.Data.SqlTypes;
using UnityEngine;

public class QuitGame : MonoBehaviour
{
    public GameObject quitPanel;

    public void Confirmation()
    {
        Time.timeScale = 0;
        quitPanel.SetActive(true);
    }

    public void ContinueGame()
    {
        Time.timeScale = 1;
        quitPanel.SetActive(false);
    }
}
