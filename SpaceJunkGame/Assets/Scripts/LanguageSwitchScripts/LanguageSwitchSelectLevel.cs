using TMPro;
using UnityEngine;

public class LanguageSwitchSelectLevel : MonoBehaviour
{
    public TextMeshProUGUI gameTitle;
    public TextMeshProUGUI lvl1;
    public TextMeshProUGUI lvl2;
    public TextMeshProUGUI lvl3;

    private void Awake()
    {
        if (LangSwitchBool.englishTxt)
        {
            gameTitle.text = "Space Janitor";
            lvl1.text = "Level";
            lvl2.text = "Level";
            lvl3.text = "Level";
        }
        else
        {
            gameTitle.text = "Ruimte Concierge";
            lvl1.text = "Niveau";
            lvl2.text = "Niveau";
            lvl3.text = "Niveau";
        }
    }
}
