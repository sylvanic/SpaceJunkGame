using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class LanguageSwitchUI : MonoBehaviour
{
    public TextMeshPro timer;
    public GameObject storageCapacity;
    public GameObject objectives;
    public GameObject challenges;
    public GameObject gameTitle;
    public GameObject quit;
    public GameObject confirmationQuit;
    public GameObject confirmationWarning;
    public GameObject confirmationYes;
    public GameObject confirmationNo;

    private void Awake()
    {
        if (LangSwitchBool.englishTxt)
        {
            timer.text = "Timer:";
        }
        else
        {
            timer.text = "Tijd:";
        }
    }
}
