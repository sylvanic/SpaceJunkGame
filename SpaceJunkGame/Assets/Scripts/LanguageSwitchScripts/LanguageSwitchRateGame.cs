using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class LanguageSwitchRateGame : MonoBehaviour
{
    public TextMeshProUGUI P1Title;
    public TextMeshProUGUI P1Enjoy;
    public TextMeshProUGUI P1Back;
    public TextMeshProUGUI P1Rate;
    [Space]
    public TextMeshProUGUI F1Title;
    public TextMeshProUGUI F1Wrong;
    public TMP_Dropdown F1DropDown;
    public TextMeshProUGUI F1Next;
    [Space]
    public TextMeshProUGUI P2Title;
    public TextMeshProUGUI P2Learning;
    public TMP_Dropdown F2DropDown;
    public TextMeshProUGUI P2Finish;
    [Space]
    public TextMeshProUGUI F2Title;
    public TextMeshProUGUI F2Wrong;

    public TextMeshProUGUI F2Finish;
    [Space]
    public TextMeshProUGUI Thanks;
    public TextMeshProUGUI Back;
    public TextMeshProUGUI Menu;


    private void Awake()
    {
        if (LangSwitchBool.englishTxt)
        {
            P1Title.text = "Rate our Game!";
            P1Enjoy.text = "Did you enjoy it?";
            P1Back.text = "Back";
            P1Rate.text = "Rate";

            F1Title.text = "Rate our Game!";
            F1Wrong.text = "What went wrong?";
            F1DropDown.options[0].text = "Controls don't work";
            F1DropDown.options[1].text = "Game crashed";
            F1DropDown.options[2].text = "Other";
            F1Next.text = "Next";

            P2Title.text = "Rate our Game!";
            P2Learning.text = "Was it a good learning experience?";
            P2Finish.text = "Finish";

            F2Title.text = "Rate our Game!";
            F2Wrong.text = "What went wrong?";
            F2DropDown.options[0].text = "Didn't learn much";
            F2DropDown.options[1].text = "Goal not clear";
            F2DropDown.options[2].text = "Other";
            F2Finish.text = "Finish";

            Thanks.text = "Thank you for your\n feedback!";
            Back.text = "Back";
            Menu.text = "Menu";

        }
        else
        {
            P1Title.text = "Beoordeel ons Spel!";
            P1Enjoy.text = "Vond je het leuk?";
            P1Back.text = "Terug";
            P1Rate.text = "Beoordel";

            F1Title.text = "Beoordeel ons Spel!";
            F1Wrong.text = "Wat ging er mis?";
            F1DropDown.options[0].text = "Controles werken niet";
            F1DropDown.options[1].text = "Spel crasht";
            F1DropDown.options[2].text = "Overige";
            F1Next.text = "Volgende";

            P2Title.text = "Beoordeel ons Spel!";
            P2Learning.text = "Was het een goede leerervaring?";
            P2Finish.text = "Einde";

            F2Title.text = "Beoordeel ons Spel!";
            F2Wrong.text = "Wat ging er mis?";
            F2DropDown.options[0].text = "Heeft niet veel geleerd";
            F2DropDown.options[1].text = "Doel niet duidelijk";
            F2DropDown.options[2].text = "Overige";
            F2Finish.text = "Einde";

            Thanks.text = "Bedankt voor uw\n feedback!";
            Back.text = "Terug";
            Menu.text = "Menu";

        }
    }

}
