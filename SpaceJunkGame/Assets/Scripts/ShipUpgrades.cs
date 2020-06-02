using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ShipUpgrades : MonoBehaviour
{
    [SerializeField]
    private bool checkChallengedCompleted;
    public GameObject UpgradeBoard;

    private Button selectedUpgradeBtn;

    private Color deselected = Color.white;
    private Color upgradeSelected = Color.black;
    public Color boosterUpg, weaponUpg, capacityUpg, shieldUpg;

    public string upgrade;

    private void Start()
    {

    }

    public void CheckChallengedCompleted()
    {
        if (checkChallengedCompleted == false)
        {
            SceneManager.LoadScene("Level2");
            Debug.Log("Challenge not comppleted");
        }
        else
        {
            UpgradeBoard.SetActive(true);
            Debug.Log("Challenge completed");
        }
    }

    public void ChallengeNextLevel()
    {
        if (checkChallengedCompleted == true)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
            Debug.Log("Welcome to level2");
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
        //shieldUpg = GameObject.Find("ShieldUpg").GetComponent<Image>().color;

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
        /*
        else if (shieldUpg == Color.black)
        {
            upgrade = "shield";
        }
        */
        if (boosterUpg == deselected &&
            weaponUpg == deselected && 
            capacityUpg == deselected)
        {
            upgrade = "";
            Debug.Log("Choose Upgrade");
        }

        Debug.Log(upgrade);
    }


}
