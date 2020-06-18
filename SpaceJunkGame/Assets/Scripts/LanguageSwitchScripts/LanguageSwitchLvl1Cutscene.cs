using UnityEngine;
using UnityEngine.UI;

public class LanguageSwitchLvl1Cutscene : MonoBehaviour
{
    public Text text1;
    public Text text2;
    public Text text3;
    public Text text3alt;

    private void Awake()
    {
        if (LangSwitchBool.englishTxt)
        {
            text1.text = "Good job! You did it, you have slightly decreased space pollution!";
            text2.text = "However...";
            text3.text = "The problem continues to grow.";
            text3alt.text = "The problem continues to grow, but you have done a great job.";
        }
        else
        {
            text1.text = "Goed gedaan! Je hebt ruimte vervuiling een beetje kunnen verminderen!";
            text2.text = "Maar…";
            text3.text = "Het probleem wordt alsmaar groter.";
            text3alt.text = "Het probleem wordt alsmaar groter, maar je hebt een goede daad verricht.";
        }
    }
}
