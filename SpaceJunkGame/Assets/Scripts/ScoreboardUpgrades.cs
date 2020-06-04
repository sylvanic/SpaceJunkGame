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
    private Color deselected = Color.white;
    private Color upgradeSelected = Color.black;
    private Color boosterUpg, weaponUpg, capacityUpg, shieldUpg;
    private string upgrade;

    private void Start()
    {
        PlayerStats.currentScore = 124;
    }
    
    public void CheckChallengeCompleted()
    {
        if (PlayerStats.currentScore > levelScoreMinimum)    /// Mission Completed
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
            SceneManager.LoadScene("GameTest");    /// Mission Failed
        }
    }

    public void ChallengeNextLevel()
    {
        if (checkChallengedCompleted == true)
        {
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
