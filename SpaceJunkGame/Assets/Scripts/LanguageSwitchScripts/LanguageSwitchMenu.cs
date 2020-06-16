using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class LanguageSwitchMenu : MonoBehaviour
{
    //top
    public GameObject gameTitle;
    //left side
    public GameObject writeYourName;
    public GameObject enterName;
    public GameObject Gender;
    public GameObject male;
    public GameObject female;
    public GameObject other;
    public GameObject AgeGroup;
    public GameObject child;
    public GameObject teen;
    public GameObject adult;
    //right side
    public GameObject startButton;
    public GameObject optionsButton;
    public GameObject leaderboardButton;
    public GameObject quitButton;

    //leaderboard section
    public GameObject leaderboard;
    public GameObject playerLeaderboard;
    public GameObject scoreLeaderboard;
    public GameObject backButtonLeaderboard;

    //options section
    public GameObject options;
    public GameObject masterVolume;
    public GameObject sfxVolume;
    public GameObject backButtonOptions;
    private void Awake()
    {
        TextMeshProUGUI gameTitleText = gameTitle.GetComponent<TextMeshProUGUI>();
        TextMeshProUGUI startButtonText = startButton.GetComponent<TextMeshProUGUI>();
        TextMeshProUGUI writeYourNameText = writeYourName.GetComponent<TextMeshProUGUI>();
        TextMeshProUGUI enterNameText = enterName.GetComponent<TextMeshProUGUI>();
        TextMeshProUGUI GenderText = Gender.GetComponent<TextMeshProUGUI>();
        TextMeshProUGUI maleText = male.GetComponent<TextMeshProUGUI>();
        TextMeshProUGUI femaleText = female.GetComponent<TextMeshProUGUI>();
        TextMeshProUGUI otherText = other.GetComponent<TextMeshProUGUI>();
        TextMeshProUGUI AgeGroupText = AgeGroup.GetComponent<TextMeshProUGUI>();
        TextMeshProUGUI childText = child.GetComponent<TextMeshProUGUI>();
        TextMeshProUGUI teenText = teen.GetComponent<TextMeshProUGUI>();
        TextMeshProUGUI adultText = adult.GetComponent<TextMeshProUGUI>();
        
        TextMeshProUGUI optionButtonText = optionsButton.GetComponent<TextMeshProUGUI>();
        TextMeshProUGUI leaderboardButtonText = leaderboardButton.GetComponent<TextMeshProUGUI>();
        TextMeshProUGUI quitbuttonText = quitButton.GetComponent<TextMeshProUGUI>();
         
        TextMeshProUGUI leaderboardText = leaderboard.GetComponent<TextMeshProUGUI>();
        TextMeshProUGUI playerLeaderboardText = playerLeaderboard.GetComponent<TextMeshProUGUI>();
        TextMeshProUGUI scoreLeaderboardText = scoreLeaderboard.GetComponent<TextMeshProUGUI>();
        TextMeshProUGUI backButtonLeaderboardText = backButtonLeaderboard.GetComponent<TextMeshProUGUI>();
         
        TextMeshProUGUI optionsText = options.GetComponent<TextMeshProUGUI>();
        TextMeshProUGUI masterVolumeText = masterVolume.GetComponent<TextMeshProUGUI>();
        TextMeshProUGUI sfxVolumeText = sfxVolume.GetComponent<TextMeshProUGUI>();
        TextMeshProUGUI backButtonOptionsText = backButtonOptions.GetComponent<TextMeshProUGUI>();

        if (LangSwitchBool.englishTxt)
        {
            gameTitleText.text = "Space Janitor";
            gameTitleText.fontSize = 150;
            startButtonText.text = "Start";
            writeYourNameText.text = "Write your name:";
            enterNameText.text = "Enter name...";
            GenderText.text = "Gender:";
            maleText.text = "male";
            femaleText.text = "female";
            otherText.text = "other";
            AgeGroupText.text = "Select your age group:";
            childText.text = "child (7+)";
            teenText.text = "teen (14+)";
            adultText.text = "adult (18+)";

            optionButtonText.text = "Options";
            leaderboardButtonText.text = "Leaderboard";
            quitbuttonText.text = "Quit";

            leaderboardText.text = "Leaderboard";
            playerLeaderboardText.text = "PLAYER";
            scoreLeaderboardText.text = "SCORE";
            backButtonLeaderboardText.text = "BACK";

            optionsText.text = "Options";
            masterVolumeText.text = "Master Volume";
            sfxVolumeText.text = "SFX Volume";
            backButtonOptionsText.text = "Back";
        }
        else
        {
            gameTitleText.text = "Ruimte Congierge";
            gameTitleText.fontSize = 120;
            startButtonText.text = "Begin";
            writeYourNameText.text = "Schrijf je naam:";
            enterNameText.text = "Vul je naam in...";
            GenderText.text = "Geslacht:";
            maleText.text = "man";
            femaleText.text = "vrouw";
            otherText.text = "overig";
            AgeGroupText.text = "Kies je leeftijdsgroep:";
            childText.text = "kind (7+)";
            teenText.text = "tiener (14+)";
            adultText.text = "volwassen (18+)";

            optionButtonText.text = "Instellingen";
            leaderboardButtonText.text = "Scorebord";
            quitbuttonText.text = "Afsluiten";
            quitbuttonText.fontSize = 24.6f;

            leaderboardText.text = "Scorebord";
            playerLeaderboardText.text = "SPELER";
            scoreLeaderboardText.text = "SCORE";
            backButtonLeaderboardText.text = "TERUG";

            optionsText.text = "Instellingen";
            optionsText.fontSize = 77;
            masterVolumeText.text = "Hoofdvolume";
            sfxVolumeText.text = "Geluidseffectvolume";
            sfxVolumeText.fontSize = 42;
            backButtonOptionsText.text = "Terug";
        }
    }

    
}
    
