using UnityEngine;

public class LangSwitchBool : MonoBehaviour
{
    public static bool englishTxt = false;
    public static string hitTaskTxt;
    public static string pickUpTaskTxt;
    public static string scoreTaskTxt;

    public void Dutch()
    {
        englishTxt = false;
    }

    public void English()
    {
        englishTxt = true;
    }

    private void Update()
    {
        if (englishTxt)
        {
            hitTaskTxt = "Get hit by an asteroid {0}/{1} times";
            pickUpTaskTxt = "Collected {0}/{1} junk";
            scoreTaskTxt = "Obtain a score of {0}/{1} points";
        }
        else
        {
            hitTaskTxt = "Word door een asteroid {0}/{1} keer geraakt";
            pickUpTaskTxt = "Verzamel {0}/{1} afval";
            scoreTaskTxt = "Verzamel {0}/{1} punten";
        }
    }
}