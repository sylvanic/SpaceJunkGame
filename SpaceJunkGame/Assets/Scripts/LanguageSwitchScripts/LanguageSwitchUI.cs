using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class LanguageSwitchUI : MonoBehaviour
{
    public TextMeshProUGUI Timer;
    public TextMeshProUGUI Score;
    public TextMeshProUGUI GameTitle;
    public TextMeshProUGUI Quit;
    public Text page1Text1;
    public Text page1Text2;
    public Text page2Text1;
    public Text page2Text2;
    public Text page3Text1;
    public Text page3Text2;
    public Text page4Text1;
    public Text page4Text2;
    public Text page5Text1;
    public Text page5Text2;
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
            page1Text1.text = "Use the directional pad on your screen to move.";
            page1Text2.text = "Press the Laser button to shoot your laser.";
            page2Text1.text = "Collect space trash and dump them at the space station.";
            page2Text2.text = "Avoid asteroids; they remove the trash you collected.";
            page3Text1.text = "To collect big space junk you must shoot them with your laser.";
            page3Text2.text = "Try doing all of this within the given amount of time, and get the highest score possible.";
            page4Text1.text = "This is the booster upgrade. It will let you go faster with your ship.";
            page4Text2.text = "This is the weapon upgrade. It will make your laser more powerful.";
            page5Text1.text = "This is the capacity upgrade. With this, you can carry more junk.";
            page5Text2.text = "This is the immunity upgrade. You're invincible from asteroids with his for a while.";

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
            page1Text1.text = "Gebruik de joystick op het scherm om te bewegen.";
            page1Text2.text = "Druk de Laser knop om je laser te schieten.";
            page2Text1.text = "Verzamel ruimteafval en stort ze bij de ruimtestation.";
            page2Text2.text = "Vermijd asteroïden; ze verwijderen het afval dat je hebt verzamelt.";
            page3Text1.text = "Om grote ruimteafval te verzamelen moet je ze eerst schieten met je laser.";
            page3Text2.text = "Probeer dit allemaal te doen binnen de gegeven tijd, en probeer de hoogste score te krijgen.";
            page4Text1.text = "Dit is de booster upgrade. Hiermee kan je sneller gaan met je schip.";
            page4Text2.text = "Dit is de wapen upgrade. Hiermee is je laser krachtiger.";
            page5Text1.text = "Dit is de capaciteitsupgrade. Hiermee kan je meer afval dragen.";
            page5Text2.text = "Dit is de immuniteitsupgrade. Hiermee wordt je voor een korte tijd onraakbaar door asteroïden.";

            Capa.image.sprite = CapacityDutch;
            Immun.image.sprite = ImmunityDutch;
            Weapon.image.sprite = WeaponDutch;
        }
    }
}
