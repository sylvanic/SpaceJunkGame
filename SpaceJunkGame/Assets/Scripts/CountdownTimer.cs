using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
using System.Security;
using System.Threading;

public class CountdownTimer : MonoBehaviour
{
    // Start is called before the first frame update
    public float _currentCountdownValue;
    public TextMeshProUGUI _timerSeconds;
    public TextMeshProUGUI countdown;
    private int fontScale = 40;
    private SoundManager soundManager;

    public string SceneName;

    void Start()
    {
        // _timerSeconds = GetComponent<TextMeshProUGUI>();
        StartCoroutine(StartCountDown());
        soundManager = GameObject.FindGameObjectWithTag("SoundManager").GetComponent<SoundManager>();


    }

    private void Update()
    {
        _timerSeconds.text = _currentCountdownValue.ToString(("f0"));
    }

    public void CutSceneOne()
    {
        SceneManager.LoadScene(SceneName);
    }


    public IEnumerator StartCountDown()
    {
        while (_currentCountdownValue > 0)
        {
            yield return new WaitForSeconds(1.0f);
            _currentCountdownValue--;

            if(_currentCountdownValue <= 5 && _currentCountdownValue >= 1)
            {
                countdown.gameObject.SetActive(true);
                countdown.color = Color.red;
                countdown.text = _currentCountdownValue.ToString();
                countdown.fontSize += fontScale;
                soundManager.Shoot.Play();
            }
        }

        //CHANGE SCENE ONCE TIME IS UP
        Debug.Log("bruh moment #3");
        soundManager.TimerBuzzer.Play();
        

        if (SceneManager.GetActiveScene().name == "GameTest")
        {
            SceneManager.LoadScene("Lvl1Cutscene");
        }
        else if (SceneManager.GetActiveScene().name == "Level_2")
        {
            SceneManager.LoadScene("Lvl2Cutscene");
        }
        else if (SceneManager.GetActiveScene().name == "Level_3")
        {
            SceneManager.LoadScene("Lvl3Cutscene");
        }       

    }
}
