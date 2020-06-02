using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Upgrades : MonoBehaviour
{
    [Header("Booster Upgrade")]  
    [SerializeField] private float upgradedMovementSpeed = 8f;
    
    [Header("Capacity Upgrade")]
    [SerializeField] private int upgradedCapacity = 0;
    
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
    }

    public void CapacityUpgrade()
    {
        GetComponentInParent<PlayerStats>().capacity = upgradedCapacity;
    }

    public void ShieldUpgrade(){
        
    }


    
}
