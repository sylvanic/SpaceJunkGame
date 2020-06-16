using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class LanguageSwitchObjectiveBoards : MonoBehaviour
{
    public TextMeshProUGUI MCTitle;
    public TextMeshProUGUI MCScore;
    public TextMeshProUGUI MCNext;
    [Space]
    public TextMeshProUGUI MFTitle;
    public TextMeshProUGUI MFScore;
    public TextMeshProUGUI MFQuit;
    public TextMeshProUGUI MFReplay;
    [Space]
    public TextMeshProUGUI Confirm;
    public TextMeshProUGUI ConfirmWarning;
    public TextMeshProUGUI ConfirmYes;
    public TextMeshProUGUI ConfirmNo;
    [Space]
    public TextMeshProUGUI CCTitle;
    public TextMeshProUGUI ChooseUpgrade;
    public TextMeshProUGUI CCNext;
    public TextMeshProUGUI ChooseUpgradeConfirm;



    private void Awake()
    {
        if (LangSwitchBool.englishTxt)
        {
            MCTitle.text = "MISSION COMPLETED!";
            MCScore.text = "SCORE:";
            MCNext.text = "NEXT";

            MFTitle.text = "MISSION FAILED!";
            MFScore.text = "SCORE:";
            MFQuit.text = "QUIT";
            MFReplay.text = "REPLAY";

            Confirm.text = "ALL progress will be LOST!";
            ConfirmWarning.text = "Sure you want to quit?";
            ConfirmYes.text = "YES";
            ConfirmNo.text = "NO";

            CCTitle.text = "CHALLENGE COMPLETED!";
            ChooseUpgrade.text = "Choose an Upgrade";
            CCNext.text = "NEXT";
            ChooseUpgradeConfirm.text = "Choose an upgrade first!";

        }
        else
        {
            MCTitle.text = "MISSIE GEHAALD!";
            MCScore.text = "AANTAL PUNTEN:";
            MCNext.text = "VOLGENDE";

            MFTitle.text = "MISSIE MISLUKT!";
            MFScore.text = "AANTAL PUNTEN:";
            MFQuit.text = "OPGEVEN";
            MFReplay.text = "OPNIEUW";

            Confirm.text = "ALLE vooruitgang zal VERLOREN gaan!";
            ConfirmWarning.text = "Zeker dat U wilt stoppen?";
            ConfirmYes.text = "JA";
            ConfirmNo.text = "NEE";

            CCTitle.text = "UITDAGING GEHAALD!";
            ChooseUpgrade.text = "Kies een upgrade";
            CCNext.text = "VOLGENDE";
            ChooseUpgradeConfirm.text = "Kies eerst een upgrade!";
        }
       
    }
}
