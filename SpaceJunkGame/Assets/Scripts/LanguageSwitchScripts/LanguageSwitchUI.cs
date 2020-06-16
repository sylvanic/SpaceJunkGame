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
        }
        else
        {
            timer.text = "Tijd:";
            storageCapacity.text = "Opslagcapaciteit";
            objectives.text = "";
            challenges.text = "";
            gameTitle.text = "";
            quit.text = "";
            confirmationQuit.text = "";
            confirmationWarning.text = "";
            confirmationYes.text = "";
            confirmationNo.text = "";
        }
    }
}
