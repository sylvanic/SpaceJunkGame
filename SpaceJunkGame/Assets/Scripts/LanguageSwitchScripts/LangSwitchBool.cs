using UnityEngine;

public class LangSwitchBool : MonoBehaviour
{
    public static bool englishTxt = false;

    public void Dutch()
    {
        englishTxt = false;
    }

    public void English()
    {
        englishTxt = true;
    }
}