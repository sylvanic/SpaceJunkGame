using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class LanguageSwitchEndScoreboard : MonoBehaviour
{
    public TextMeshProUGUI ESTitle;
    public TextMeshProUGUI Level1;
    public TextMeshProUGUI Level2;
    public TextMeshProUGUI Level3;
    public TextMeshProUGUI TotalScore;
    public TextMeshProUGUI Replay;
    public TextMeshProUGUI Username;
    public TextMeshProUGUI Rate;

    //player details
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
    public TextMeshProUGUI saveresults;
    public Text clearresults;
    public Text save;

    private void Awake()
    {
        if (LangSwitchBool.englishTxt)
        {
            ESTitle.text = "GAME COMPLETED!";
            Level1.text = "LEVEL 1:";
            Level2.text = "LEVEL 2:";
            Level3.text = "LEVEL 3:";
            TotalScore.text = "TOTAL SCORE";
            Replay.text = "REPLAY";
            Username.text = "NEXT";
            Rate.text = "RATE GAME";

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
            saveresults.text = "Do you wish to save the results?";
            clearresults.text = "Clear Results";
            save.text = "Save";
        }
        else
        {
            ESTitle.text = "SPEL AFGEROND!";
            Level1.text = "NIVEAU 1:";
            Level2.text = "NIVEAU 2:";
            Level3.text = "NIVEAU 3:";
            TotalScore.text = "TOTALE PUNTEN";
            Replay.text = "OPNIEUW";
            Username.text = "VOLGENDE";
            Rate.text = "BEOORDEEL SPEL";

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
            saveresults.text = "Wil je je resultaten opslaan?";
            clearresults.text = "Wis Resultaat";
            save.text = "Opslaan";
        }
    }


}
