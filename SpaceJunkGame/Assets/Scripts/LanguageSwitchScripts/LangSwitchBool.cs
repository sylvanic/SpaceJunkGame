using UnityEngine;

public class LangSwitchBool : MonoBehaviour
{
    public static bool englishTxt = true;

    public void Dutch()
    {
        englishTxt = false;
    }

    public void English()
    {
        englishTxt = true;
    }
}
