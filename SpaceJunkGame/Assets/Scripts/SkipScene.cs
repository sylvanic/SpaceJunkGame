using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SkipScene : MonoBehaviour
{
    public Button nextLevel;

    // Start is called before the first frame update
    void Start()
    {
        nextLevel = nextLevel.GetComponent<Button>();
    }

    public void SkipLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
