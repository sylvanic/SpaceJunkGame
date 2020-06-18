using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivateUpgrade : MonoBehaviour
{
    private Upgrades upgrades;
    public GameObject BoosterCard, CapacityCard, WeaponCard, ImmunityCard;

    private void Awake()
    {
        upgrades = GetComponent<Upgrades>();

        switch (ResultScreens.currentUpgrade)
        {
            case "booster":
                BoosterCard.SetActive(true);
                break;
            case "capacity":
                 upgrades.CapacityUpgrade();
                CapacityCard.SetActive(true);
                break;
            case "shield":
                ImmunityCard.SetActive(true);
                break;
            case "weapon":
                upgrades.GunUpgrade();
                WeaponCard.SetActive(true);
                break;
        }

        switch (ResultScreens.currentUpgrade2)
        {
            case "booster":
                BoosterCard.SetActive(true);
                break;
            case "capacity":
                upgrades.CapacityUpgrade();
                CapacityCard.SetActive(true);
                break;
            case "shield":
                ImmunityCard.SetActive(true);
                break;
            case "weapon":
                upgrades.GunUpgrade();
                WeaponCard.SetActive(true);
                break;
        }
    }
}
