using UnityEngine;

public class LanguageSwitch : MonoBehaviour
{
    public static bool englishTxt;
    public GameObject gameTitleEng;
    public GameObject gameTitleDutch;
    private void Update()
    {
        if (englishTxt)
        {
            gameTitleEng.SetActive(true);
            gameTitleDutch.SetActive(false);
        }
        else
        {
            gameTitleEng.SetActive(false);
            gameTitleDutch.SetActive(true);
        }
    }

    public void Dutch()
    {
        englishTxt = false;
    }

    public void English()
    {
        englishTxt = true;
    }
}
    
