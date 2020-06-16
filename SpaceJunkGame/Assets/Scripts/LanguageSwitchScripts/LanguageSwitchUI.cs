using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class LanguageSwitchUI : MonoBehaviour
{
    public TextMeshProUGUI timer;
    public Text storageCapacity;
    public Text objectives;
    public Text challenges;
    public TextMeshProUGUI gameTitle;
    public TextMeshProUGUI quit;
    public TextMeshProUGUI confirmationQuit;
    public TextMeshProUGUI confirmationWarning;
    public TextMeshProUGUI confirmationYes;
    public TextMeshProUGUI confirmationNo;

    private void Awake()
    {
        if (LangSwitchBool.englishTxt)
        {
            timer.text = "Timer:";
            storageCapacity.text = "Storage Capacity";
            objectives.text = "Objectives";
            challenges.text = "Challenges";
            gameTitle.text = "Space Janitor";
            quit.text = "";
            confirmationQuit.text = "";
            confirmationWarning.text = "";
            confirmationYes.text = "";
            confirmationNo.text = "";
        }
        else
        {
            timer.text = "Tijd:";
            storageCapacity.text = "Opslagcapaciteit";
            objectives.text = "Doelen";
            challenges.text = "Uitdagingen";
            gameTitle.text = "Ruimte Concierge";
            quit.text = "";
            confirmationQuit.text = "";
            confirmationWarning.text = "";
            confirmationYes.text = "";
            confirmationNo.text = "";
        }
    }
}
