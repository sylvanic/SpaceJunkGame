using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SelectLevel : MonoBehaviour
{
    public Button[] buttons;

    private void Start()
    {
        for (int i = 0; i < buttons.Length; i++)
        {
            int closureIndex = i; // Prevents the closure problem
            buttons[closureIndex].onClick.AddListener(() => TaskOnClick(closureIndex));
        }
    }

    public void TaskOnClick(int buttonIndex)
    {
        //Debug.Log("You have clicked the button #" + buttonIndex, buttons[buttonIndex]);

        switch (buttonIndex)
        {
            case 0:
                SceneManager.LoadScene("GameTest");
                break;
            case 1:
                SceneManager.LoadScene("Level_2");
                break;
            case 2:
                SceneManager.LoadScene("Level_3");
                break;

        }
    }
}