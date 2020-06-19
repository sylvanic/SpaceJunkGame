using TMPro;
using UnityEngine;

public class LanguageSwitchSelectLevel : MonoBehaviour
{
    public TextMeshProUGUI gameTitle;
    public TextMeshProUGUI lvl1;
    public TextMeshProUGUI lvl2;
    public TextMeshProUGUI lvl3;
    public TextMeshProUGUI Back;

    private void Awake()
    {
        if (LangSwitchBool.englishTxt)
        {
            gameTitle.text = "Space Janitor";
            lvl1.text = "Level";
            lvl2.text = "Level";
            lvl3.text = "Level";
            Back.text = "MENU";
        }
        else
        {
            gameTitle.text = "Ruimte Schoonmaker";
            lvl1.text = "Niveau";
            lvl2.text = "Niveau";
            lvl3.text = "Niveau";
            Back.text = "MENU";
        }
    }
}
