using UnityEngine;
using UnityEngine.SceneManagement;


public class UpgradeSelection : MonoBehaviour
{
    private string previousUpgrade;
    private string previousUpgrade2;

    private void Update()
    {
        if (SceneManager.GetActiveScene().name == "Lvl1Cutscene")
        {
            UpgradesLevel1();
        }
        else if (SceneManager.GetActiveScene().name == "Lvl2Cutscene")
        {
            UpgradesLevel2();
        }
    }

    private void UpgradesLevel1()
    {
        if (ResultScreens.currentUpgrade != previousUpgrade)
        {
            switch (previousUpgrade)
            {
                case "booster":
                    PlayerPrefs.SetInt("HasBooster", 0);
                    break;
                case "weapon":
                    PlayerPrefs.SetInt("HasWeapon", 0);
                    break;
                case "capacity":
                    PlayerPrefs.SetInt("HasCapacity", 0);
                    break;
                case "shield":
                    PlayerPrefs.SetInt("HasShield", 0);
                    break;
            }

            previousUpgrade = ResultScreens.currentUpgrade;
        }


        switch (ResultScreens.currentUpgrade)
        {
            case "booster":
                PlayerPrefs.SetInt("HasBooster", 1);
                break;
            case "weapon":
                PlayerPrefs.SetInt("HasWeapon", 1);
                break;
            case "capacity":
                PlayerPrefs.SetInt("HasCapacity", 1);
                break;
            case "shield":
                PlayerPrefs.SetInt("HasShield", 1);
                break;
        }
    }

    private void UpgradesLevel2()
    {
        if (ResultScreens.currentUpgrade2 != previousUpgrade2)
        {
            switch (previousUpgrade2)
            {
                case "booster":
                    PlayerPrefs.SetInt("HasBooster2", 0);
                    break;
                case "weapon":
                    PlayerPrefs.SetInt("HasWeapon2", 0);
                    break;
                case "capacity":
                    PlayerPrefs.SetInt("HasCapacity2", 0);
                    break;
                case "shield":
                    PlayerPrefs.SetInt("HasShield2", 0);
                    break;
            }

            previousUpgrade = ResultScreens.currentUpgrade2;
        }


        switch (ResultScreens.currentUpgrade2)
        {
            case "booster":
                PlayerPrefs.SetInt("HasBooster2", 1);
                break;
            case "weapon":
                PlayerPrefs.SetInt("HasWeapon2", 1);
                break;
            case "capacity":
                PlayerPrefs.SetInt("HasCapacity2", 1);
                break;
            case "shield":
                PlayerPrefs.SetInt("HasShield2", 1);
                break;
        }
    }

}
