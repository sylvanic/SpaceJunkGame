using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Upgrades : MonoBehaviour
{
    [Header("Movement Speed Upgrades")]
    [SerializeField] float upgradedMovementSpeed = 50;
    private float defaultMovementSpeed;
    public bool boostersUpgraded = false;
    
    [Header("Capacity Upgrades")]
    [SerializeField] float upgradedCapacity = 5;
    public bool capacityUpgraded = false;
    
    void Start()
    {
        defaultMovementSpeed = GetComponentInParent<PlayerController>().movementSpeed;
    }

    // Update is called once per frame
    void Update()
    {
        Booster();
    }

    void Booster(){
        if(boostersUpgraded==true){
            GetComponentInParent<PlayerController>().movementSpeed = upgradedMovementSpeed;
        }
        else{
            GetComponentInParent<PlayerController>().movementSpeed = defaultMovementSpeed;
        }
    }
    
}
