using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;

public class ScoreboardUpgrades : MonoBehaviour
{
    [SerializeField]
    private bool checkChallengedCompleted;
    public int levelScoreMinimum = 50;
    public GameObject UpgradeBoard;
    public GameObject MissionCompleted;
    [Space]
    private Button selectedUpgradeBtn;
    public static Color deselected = Color.white;
    private Color upgradeSelected = Color.black;
    public static Color boosterUpg, weaponUpg, capacityUpg, shieldUpg;
    private string upgrade;

    public GameObject checkChosenUpgrade;

    public void CheckChallengeCompleted()
    {
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
        else    /// Mission Failed
            
        {
            if (SceneManager.GetActiveScene().name == "GameTest")
            {
                SceneManager.LoadScene("GameTest");
            }
            else if (SceneManager.GetActiveScene().name == "Level_2")
            {
                SceneManager.LoadScene("Level_2");
            }

            selectedUpgradeBtn.IsActive
        }
    }

    private void Update()
    {
        Debug.Log(upgrade);
    }

    public void CheckUpgradeSelected()
    {
        if (upgrade == null || upgrade == "")
        {
            checkChosenUpgrade.SetActive(true);
        }
        else
        {
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

        if (boosterUpg == Color.black)
        {
            upgrade = "booster";
        }
        else if (weaponUpg == Color.black)
        {
            upgrade = "weapon";
        }
        else if (capacityUpg == Color.black)
        {
            upgrade = "capacity";
        }
        
        else if (shieldUpg == Color.black)
        {
            upgrade = "shield";
        }
       
        if (boosterUpg == deselected &&
            weaponUpg == deselected && 
            capacityUpg == deselected &&
            shieldUpg == deselected)
        {
            upgrade = "";
        }
    }


}
