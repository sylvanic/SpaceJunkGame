using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class CountdownTimer : MonoBehaviour
{
    // Start is called before the first frame update
    public float _currentCountdownValue;
    private TextMeshProUGUI _timerSeconds;

    public string SceneName;

    void Start()
    {
        _timerSeconds = GetComponent<TextMeshProUGUI>();
        StartCoroutine(StartCountDown());
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
        }
        //CHANGE SCENE ONCE TIME IS UP
        Debug.Log("bruh moment #3");
        CutSceneOne();

    }
}
