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
    [Space]
    public Button Capa;
    public Button Immun;
    public Button Weapon;

    public Sprite CapacityEng;
    public Sprite CapacityDutch;

    public Sprite ImmunityEng;
    public Sprite ImmunityDutch;

    public Sprite WeaponEng;
    public Sprite WeaponDutch;


    private void Awake()
    {
        if (LangSwitchBool.englishTxt)
        {
            Timer.text = "Timer: ";
            Score.text = "Score: ";
            Score.fontSize = 34;
            GameTitle.text = "Space Janitor";
            Quit.text = "QUIT";
            StorageCapacity.text = "Storage Capacity";
            Objectives.text = "OBJECTIVES";
            Challenges.text = "CHALLENGES";
            LaserTitle.text = "Laser";

            Confirm.text = "ALL progress will be LOST!";
            ConfirmWarning.text = "Sure you want to quit?";
            ConfirmYes.text = "YES";
            ConfirmNo.text = "NO";

            Capa.image.sprite = CapacityEng;
            Immun.image.sprite = ImmunityEng;
            Weapon.image.sprite = WeaponEng;
        }
        else
        {
            Timer.text = "Tijd: ";
            Score.text = "Punten: ";
            Score.fontSize = 30;
            GameTitle.text = "Ruimte Schoonmaker";
            Quit.text = "OPGEVEN";
            StorageCapacity.text = "Opslagcapaciteit";
            Objectives.text = "DOELEN";
            Challenges.text = "UITDAGINGEN";
            LaserTitle.text = "Laser";
            Confirm.text = "ALLE vooruitgang zal VERLOREN gaan!";
            ConfirmWarning.text = "Zeker dat U wilt stoppen?";
            ConfirmYes.text = "JA";
            ConfirmNo.text = "NEE";

            Capa.image.sprite = CapacityDutch;
            Immun.image.sprite = ImmunityDutch;
            Weapon.image.sprite = WeaponDutch;
        }
    }
}
