using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class LanguageSwitchMenu : MonoBehaviour
{
    //top
    public TextMeshProUGUI gameTitle;
    //left side
    public TextMeshProUGUI writeYourName;
    public TextMeshProUGUI enterName;
    public TextMeshProUGUI Gender;
    public TextMeshProUGUI male;
    public TextMeshProUGUI female;
    public TextMeshProUGUI other;
    public TextMeshProUGUI AgeGroup;
    public TextMeshProUGUI child;
    public TextMeshProUGUI teen;
    public TextMeshProUGUI adult;
    //right side
    public TextMeshProUGUI startButton;
    public TextMeshProUGUI optionsButton;
    public TextMeshProUGUI leaderboardButton;
    public TextMeshProUGUI quitButton;

    //leaderboard section
    public TextMeshProUGUI leaderboard;
    public TextMeshProUGUI playerLeaderboard;
    public TextMeshProUGUI scoreLeaderboard;
    public TextMeshProUGUI backButtonLeaderboard;

    //options section
    public TextMeshProUGUI options;
    public TextMeshProUGUI masterVolume;
    public TextMeshProUGUI sfxVolume;
    public TextMeshProUGUI backButtonOptions;
    private void Update()
    {
        if (LangSwitchBool.englishTxt)
        {
            gameTitle.text = "Space Janitor";
            gameTitle.fontSize = 150;
            startButton.text = "Start";
            writeYourName.text = "Write your name:";
            enterName.text = "Enter name...";
            Gender.text = "Gender:";
            male.text = "male";
            female.text = "female";
            other.text = "other";
            AgeGroup.text = "Select your age group:";
            child.text = "child (7+)";
            teen.text = "teen (14+)";
            adult.text = "adult (18+)";

            optionsButton.text = "Options";
            leaderboardButton.text = "Leaderboard";
            quitButton.text = "Quit";

            leaderboard.text = "Leaderboard";
            playerLeaderboard.text = "PLAYER";
            scoreLeaderboard.text = "SCORE";
            backButtonLeaderboard.text = "BACK";

            options.text = "Options";
            masterVolume.text = "Master Volume";
            sfxVolume.text = "SFX Volume";
            backButtonOptions.text = "Back";
        }
        else
        {
            gameTitle.text = "Ruimte Congierge";
            gameTitle.fontSize = 120;
            startButton.text = "Begin";
            writeYourName.text = "Schrijf je naam:";
            enterName.text = "Vul je naam in...";
            Gender.text = "Geslacht:";
            male.text = "man";
            female.text = "vrouw";
            other.text = "overig";
            AgeGroup.text = "Kies je leeftijdsgroep:";
            child.text = "kind (7+)";
            teen.text = "tiener (14+)";
            adult.text = "volwassen (18+)";

            optionsButton.text = "Instellingen";
            leaderboardButton.text = "Scorebord";
            quitButton.text = "Afsluiten";
            quitButton.fontSize = 24.6f;

            leaderboard.text = "Scorebord";
            playerLeaderboard.text = "SPELER";
            scoreLeaderboard.text = "SCORE";
            backButtonLeaderboard.text = "TERUG";

            options.text = "Instellingen";
            options.fontSize = 77;
            masterVolume.text = "Hoofdvolume";
            sfxVolume.text = "Geluidseffectvolume";
            sfxVolume.fontSize = 42;
            backButtonOptions.text = "Terug";
        }
    }

    
}
    
