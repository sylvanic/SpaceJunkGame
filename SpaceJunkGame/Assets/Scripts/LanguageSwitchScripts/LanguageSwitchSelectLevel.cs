using TMPro;
using UnityEngine;

public class LanguageSwitchSelectLevel : MonoBehaviour
{
    public TextMeshProUGUI gameTitle;
    public TextMeshProUGUI lvl1;
    public TextMeshProUGUI lvl2;
    public TextMeshProUGUI lvl3;
    public TextMeshProUGUI Back;

    public TextMeshProUGUI Confirm;
    public TextMeshProUGUI ConfirmWarning;
    public TextMeshProUGUI ConfirmYes;
    public TextMeshProUGUI ConfirmNo;

    private void Awake()
    {
        if (LangSwitchBool.englishTxt)
        {
            gameTitle.text = "Space Janitor";
            lvl1.text = "Level";
            lvl2.text = "Level";
            lvl3.text = "Level";
            Back.text = "MENU";

            Confirm.text = "ALL progress will be LOST!";
            ConfirmWarning.text = "Sure you want to quit?";
            ConfirmYes.text = "YES";
            ConfirmNo.text = "NO";
        }
        else
        {
            gameTitle.text = "Ruimte Schoonmaker";
            lvl1.text = "Niveau";
            lvl2.text = "Niveau";
            lvl3.text = "Niveau";
            Back.text = "MENU";

            Confirm.text = "ALLE vooruitgang zal VERLOREN gaan!";
            ConfirmWarning.text = "Zeker dat U wilt stoppen?";
            ConfirmYes.text = "JA";
            ConfirmNo.text = "NEE";
        }
    }
}
