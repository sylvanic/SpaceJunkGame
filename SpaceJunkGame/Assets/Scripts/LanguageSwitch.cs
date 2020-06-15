using UnityEngine;
using UnityEngine.UI;

public class LanguageSwitch : MonoBehaviour
{
    public bool EnglishText = true;
    public bool DutchText = false;

    public Text txt;

    public void ChangeTitleLang()
    {
        if (EnglishText)
        {
            txt.text = engName;
        }
        if (DutchText)
        {
            txt.text = "Ruimte Concierge";
        }
    }
}
    
