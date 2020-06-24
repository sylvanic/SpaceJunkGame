using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class LanguageSwitchIntro : MonoBehaviour
{
    public GameObject video;
    public GameObject videoNL;
    private void Awake()
    {
        if (LangSwitchBool.englishTxt)
        {
            video.SetActive(true);
        }
        else
        {
            videoNL.SetActive(true);
        }
    }
}