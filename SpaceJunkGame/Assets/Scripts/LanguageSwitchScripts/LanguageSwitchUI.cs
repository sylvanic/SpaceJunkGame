using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class LanguageSwitchUI : MonoBehaviour
{
    public TextMeshProUGUI Timer;
    public TextMeshProUGUI Score;
    public TextMeshProUGUI GameTitle;
    public TextMeshProUGUI Quit;

    public Text StorageCapacity;

    public Text Objectives;
    public Text Challenges;

    public Text LaserTitle;

    public TextMeshProUGUI Confirm;
    public TextMeshProUGUI ConfirmWarning;
    public TextMeshProUGUI ConfirmYes;
    public TextMeshProUGUI ConfirmNo;


    private void Awake()
    {
        if (LangSwitchBool.englishTxt)
        {
            Timer.text = "Timer: ";
            //Score.text = "Score: ";
            GameTitle.text = "Space Janitor";
            Quit.text = "Quit";
            StorageCapacity.text = "Storage Capacity";
            Objectives.text = "Objectives";
            Challenges.text = "Challenges";
            LaserTitle.text = "Laser";

            Confirm.text = "ALL progress will be LOST!";
            ConfirmWarning.text = "Sure you want to quit?";
            ConfirmYes.text = "YES";
            ConfirmNo.text = "NO";
        }
        else
        {
            Timer.text = "Tijd: ";
            //Score.text = "Punten: ";
            GameTitle.text = "Ruimte Congierge";
            Quit.text = "Opgeven";
            StorageCapacity.text = "Opslagcapaciteit";
            Objectives.text = "Doelen";
            Challenges.text = "Uitdagingen";
            LaserTitle.text = "Laser";
            Confirm.text = "ALLE vooruitgang zal VERLOREN gaan!";
            ConfirmWarning.text = "Zeker dat U wilt stoppen?";
            ConfirmYes.text = "JA";
            ConfirmNo.text = "NEE";
        }
    }
}
