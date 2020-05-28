using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SceneManagement : MonoBehaviour
{
    public Button mainMenu;

    // Start is called before the first frame update
    void Start()
    {
        mainMenu = mainMenu.GetComponent<Button>();
    }

    public void GoBack()
    {
        SceneManager.LoadScene(0);
    }
}
