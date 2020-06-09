using UnityEngine;

public class UpgradeSelection : MonoBehaviour
{
    private Upgrades upgrades;
    private string previousUpgrade;

    // Start is called before the first frame update
    void Start()
    {
        upgrades = GameObject.FindGameObjectWithTag("Player").GetComponent<Upgrades>();
    }

    // Update is called once per frame
    private void Update()
    {
        
        if (ResultScreens.currentUpgrade != previousUpgrade)
        {
            switch (previousUpgrade)
            {
                case "booster":
                    DeselectBooster();
                    break;
                case "weapon":
                    DeselectWeapon();
                    break;
                case "capacity":
                    DeselectCapacity();
                    break;
                case "shield":
                    DeselectShield();
                    break;
            }

            previousUpgrade = ResultScreens.currentUpgrade;
        }
        

        switch (ResultScreens.currentUpgrade)
        {
            case "booster":
                upgrades.BoosterUpgrade();
                break;
            case "weapon":
                upgrades.GunUpgrade();
                break;
            case "capacity":
                upgrades.CapacityUpgrade();
                break;
            case "shield":
                upgrades.ShieldUpgrade();
                break;
        }
    }

    
    private void DeselectBooster()
    {
        upgrades.boosterObj.SetActive(false);
    }

    private void DeselectWeapon()
    {
        upgrades.gunObj.SetActive(false);
    }

    private void DeselectCapacity()
    {
        upgrades.capacityObj.SetActive(false);
    }

    private void DeselectShield()
    {
        upgrades.shieldObj.SetActive(false);
    }
}
