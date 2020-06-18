using UnityEngine;
using UnityEngine.UI;

public class LanguageSwitchLvl2Cutscene : MonoBehaviour
{
    public Text text1;
    public Text text2;
    public Text text3;
    public Text text3alt;

    private void Awake()
    {
        if (LangSwitchBool.englishTxt)
        {
            text1.text = "Great Job! That was ... unexpected but you did it. Another mission success.";
            text2.text = "Computer: WARNING! DANGER APPROACHING SECTOR 7.";
            text3.text = "OH NO! We celebrated too early. We have unfinished business to attend to.";
            text3alt.text = "OH NO! Watch out!";
        }
        else
        {
            text1.text = "Goed gedaan! Dat was… niet verwacht, maar je hebt het gedaan. Nog een missie succesvol volbracht.";
            text2.text = "Computer: WAARSCHUWING! GEVAAR NADERT SECTOR 7.";
            text3.text = "OH NEE! We hebben ons overwinning te vroeg gevierd. We hebben wat onafgemaakte zaken om bij te wonen.";
            text3alt.text = "OH NEE! Kijk uit!";
        }
    }
}
