using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class LanguageSwitchLeaderboard : MonoBehaviour
{
    public TextMeshProUGUI player;
    public TextMeshProUGUI rank;
    public TextMeshProUGUI leaderboard;
    public TextMeshProUGUI back;
    public TextMeshProUGUI reset;
    public TextMeshProUGUI resetleaderboard;

    private void Awake()
    {
        if (LangSwitchBool.englishTxt)
        {
            player.text = "Player";
            rank.text = "Rank";
            leaderboard.text = "LEADERBOARD";
            back.text = "BACK";
            reset.text = "Leaderboard will reset in:";
            resetleaderboard.text = "Reset Leaderboard";
        }
        else
        {
            player.text = "Speler";
            rank.text = "Rang";
            leaderboard.text = "SCOREBORD";
            back.text = "Terug ";
            reset.text = "Scoreboard zal opnieuw ingestelt worden in:";
            reset.fontSize = 37;
            resetleaderboard.text = "Stel Scoreboard Opnieuw In";
            resetleaderboard.fontSize = 15;
        }
    }
}
