using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ScoreResults : MonoBehaviour
{

    public GameObject BronzeStar;
    public GameObject SilverStar; 
    public GameObject GoldStar;

    public int OneStar = 50;
    public int TwoStar = 100;
    public int ThreeStar = 150;

    Color tmpBronze;
    Color tmpSilver;
    Color tmpGold;

    public TextMeshProUGUI scoreboardScore;


    void Start()
    {
        scoreboardScore.text = PlayerStats.totalScore.ToString();
        Stars();
    }
    
    private void Stars()
    {
        tmpBronze = BronzeStar.GetComponent<Image>().color;
        tmpSilver = SilverStar.GetComponent<Image>().color;
        tmpGold = GoldStar.GetComponent<Image>().color;


        if (PlayerStats.totalScore > OneStar)
        {
            tmpBronze.a = 1f;
            BronzeStar.GetComponent<Image>().color = tmpBronze;

            if (PlayerStats.totalScore > TwoStar)
            {
                tmpSilver.a = 1f;
                SilverStar.GetComponent<Image>().color = tmpSilver;

                if (PlayerStats.totalScore > ThreeStar)
                {
                    tmpGold.a = 1f;
                    GoldStar.GetComponent<Image>().color = tmpGold;
                }
            }
        }


    }
}
