using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class EndResult : MonoBehaviour
{
    public TextMeshProUGUI lvl1score;
    public TextMeshProUGUI lvl2score;
    public TextMeshProUGUI lvl3score;
    public TextMeshProUGUI totalScore;

    private void Start()
    {
        lvl1score.text = PlayerPrefs.GetInt("ScoreLevel1").ToString();
        lvl2score.text = PlayerPrefs.GetInt("ScoreLevel2").ToString();
        lvl3score.text = PlayerPrefs.GetInt("ScoreLevel3").ToString();
        totalScore.text = PlayerPrefs.GetInt("Highscore").ToString();

    }

}
