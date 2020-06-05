using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Upgrades : MonoBehaviour
{
    [Header("Booster Upgrade")]  
    [SerializeField] private float upgradedMovementSpeed = 8f;
    public GameObject boosterObj;
    
    [Header("Capacity Upgrade")]
    [SerializeField] private int upgradedCapacity = 0;
    public GameObject capacityObj;

    [Header("Gun Upgrade")]
    public GameObject gunObj;

    [Header("Shield Upgrade")]
    public GameObject shieldObj;
    public bool isShieldActive = false;

    

    
    void Start()
    {
     
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void BoosterUpgrade()
    {
       GetComponentInParent<PlayerController>().movementSpeed = upgradedMovementSpeed;
       boosterObj.SetActive(true);
        
    }

    public void CapacityUpgrade()
    {
        GetComponentInParent<PlayerStats>().capacity = upgradedCapacity;
        capacityObj.SetActive(true);

    }

    public void ShieldUpgrade(){
        shieldObj.SetActive(true);
    }

    public void GunUpgrade(){
        gunObj.SetActive(true);
    }


    
}
