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

        if (PlayerPrefs.GetInt("HasBooster") == 1)
        {
            upgrades.BoosterUpgrade();
            BoosterCard.SetActive(true);
        }

        else if (PlayerPrefs.GetInt("HasCapacity") == 1)
        {
            upgrades.CapacityUpgrade();
            CapacityCard.SetActive(true);
        }

        else if (PlayerPrefs.GetInt("HasShield") == 1)
        {
            upgrades.ShieldUpgrade();
            ImmunityCard.SetActive(true);
        }

        else if (PlayerPrefs.GetInt("HasWeapon") == 1)
        {
            upgrades.GunUpgrade();
            WeaponCard.SetActive(true);
        }
    }
}
