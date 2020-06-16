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
    [SerializeField] private float shieldTime = 0;
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
       float _originalSpeed = GetComponentInParent<PlayerController>().movementSpeed;
       GetComponentInParent<PlayerController>().movementSpeed = upgradedMovementSpeed;
       boosterObj.SetActive(true);
       StartCoroutine(ActivateBooster(3,_originalSpeed));

        if (ResultScreens.currentUpgrade == "")
        {
            boosterObj.SetActive(false);
        }
        
    }

    public IEnumerator ActivateBooster(float boostTime, float originalSpeed){
        yield return new WaitForSeconds(boostTime);
        GetComponentInParent<PlayerController>().movementSpeed = originalSpeed;
        boosterObj.SetActive(false);
    }

    public void CapacityUpgrade()
    {
        GetComponentInParent<PlayerStats>().capacity = upgradedCapacity;
        capacityObj.SetActive(true);

    }

    public void ShieldUpgrade()
    {
        shieldObj.SetActive(true);
        GetComponent<BoxCollider>().enabled=false;
        StartCoroutine(ActivateShield(shieldTime));

    }

    public IEnumerator ActivateShield(float waitTime)
    {   
        yield return new WaitForSeconds(waitTime);
        GetComponent<BoxCollider>().enabled=true;
    }

    public void GunUpgrade()
    {
        GetComponent<PlayerController>().currentProjectile = GetComponent<PlayerController>().upgradedProjectile;
        gunObj.SetActive(true);
    }

    
}
