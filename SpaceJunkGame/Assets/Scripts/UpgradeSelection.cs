using UnityEngine;

public class UpgradeSelection : MonoBehaviour
{
    private string previousUpgrade;

    // Start is called before the first frame update

    private void Awake()
    {
        PlayerPrefs.GetString("ChosenUpgrade");
    }

    void Start()
    {
    }

    // Update is called once per frame
    private void Update()
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

}
