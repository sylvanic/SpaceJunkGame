using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;

public class ResultScreens : MonoBehaviour
{
    public bool checkChallengedCompleted;
    public int levelScoreMinimum = 50;
    public GameObject UpgradeBoard;
    public GameObject MissionCompleted;
    [Space]
    private Button selectedUpgradeBtn;
    private Color deselected = Color.white;
    public Color upgradeSelected = Color.blue;
    private Color boosterUpg, weaponUpg, capacityUpg, shieldUpg;
    public static string currentUpgrade;

    public GameObject checkChosenUpgrade;


    public void CheckChallengeCompleted()
    {
        Debug.Log("clicked");

        if (PlayerStats.totalScore > levelScoreMinimum)    /// Mission Completed
        {
            if (checkChallengedCompleted == false)
            {
                SceneManager.LoadScene("SelectLevel");
            }
            else
            {
                UpgradeBoard.SetActive(true);      /// Challenge Completed
                MissionCompleted.SetActive(false);
            }
        }
        else   
        {
            if (SceneManager.GetActiveScene().name == "Lvl1Cutscene")
            {
                SceneManager.LoadScene("GameTest");
            }
            else if (SceneManager.GetActiveScene().name == "Lvl2Cutscene")
            {
                SceneManager.LoadScene("Level_2");
            }
            else if (SceneManager.GetActiveScene().name == "Lvl3Cutscene")
            {
                SceneManager.LoadScene("Level_3");
            }

        }

      
    }

    public void ShowEndScreen()
    {
        SceneManager.LoadScene("EndScreen");
    }

    public void CheckUpgradeSelected()
    {
        if (currentUpgrade == null || currentUpgrade == "")
        {
            checkChosenUpgrade.SetActive(true);
        }
        else
        {
            PlayerPrefs.SetString("ChosenUpgrade", currentUpgrade);
            checkChosenUpgrade.SetActive(false);
            SceneManager.LoadScene("SelectLevel");
        }
    }

    public void UpgradeSelected(Button button)
    {
        if (selectedUpgradeBtn == button)
        {
            button.GetComponent<Image>().color = deselected;
            selectedUpgradeBtn = null;
        }
        else
        {
            if (selectedUpgradeBtn != null)
            {
                selectedUpgradeBtn.GetComponent<Image>().color = deselected;
            }
            button.GetComponent<Image>().color = upgradeSelected;
            selectedUpgradeBtn = button;
        }

        boosterUpg = GameObject.Find("BoosterUpg").GetComponent<Image>().color;
        weaponUpg = GameObject.Find("WeaponUpg").GetComponent<Image>().color;
        capacityUpg = GameObject.Find("CapacityUpg").GetComponent<Image>().color;
        shieldUpg = GameObject.Find("ShieldUpg").GetComponent<Image>().color;

        if (boosterUpg == upgradeSelected)
        {
            currentUpgrade = "booster";
        }
        else if (weaponUpg == upgradeSelected)
        {
            currentUpgrade = "weapon";
        }
        else if (capacityUpg == upgradeSelected)
        {
            currentUpgrade = "capacity";
        }
        
        else if (shieldUpg == upgradeSelected)
        {
            currentUpgrade = "shield";
        }
       
        if (boosterUpg == deselected &&
            weaponUpg == deselected && 
            capacityUpg == deselected &&
            shieldUpg == deselected)
        {
            currentUpgrade = "";
        }
    }


}
