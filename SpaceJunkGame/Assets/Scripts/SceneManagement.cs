using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SceneManagement : MonoBehaviour
{

    // Start is called before the first frame update
   

    public void ReturnToMainMenu()
    {
        SceneManager.LoadScene("NEW_Menu");
    }

    public void FamiliarWithSpaceJunk()
    {
        SceneManager.LoadScene("Tutorial");
    }
}
