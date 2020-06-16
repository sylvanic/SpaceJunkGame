using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class LanguageSwitchEndScoreboard : MonoBehaviour
{
    public TextMeshProUGUI ESTitle;
    public TextMeshProUGUI Level1;
    public TextMeshProUGUI Level2;
    public TextMeshProUGUI Level3;
    public TextMeshProUGUI TotalScore;
    public TextMeshProUGUI Replay;
    public TextMeshProUGUI Menu;
    public TextMeshProUGUI Rate;

    private void Awake()
    {
        if (LangSwitchBool.englishTxt)
        {
            ESTitle.text = "GAME COMPLETED!";
            Level1.text = "LEVEL 1:";
            Level2.text = "LEVEL 2:";
            Level3.text = "LEVEL 3:";
            TotalScore.text = "TOTAL SCORE";
            Replay.text = "REPLAY";
            Menu.text = "MENU";
            Rate.text = "RATE GAME";
        }
        else
        {
            ESTitle.text = "SPEL AFGEROND!";
            Level1.text = "NIVEAU 1:";
            Level2.text = "NIVEAU 2:";
            Level3.text = "NIVEAU 3:";
            TotalScore.text = "TOTALE PUNTEN";
            Replay.text = "OPNIEUW";
            Menu.text = "MENU";
            Rate.text = "BEOORDEEL SPEL";
        }
    }


}
