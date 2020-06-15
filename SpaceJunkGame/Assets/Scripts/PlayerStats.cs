﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;


public class PlayerStats : MonoBehaviour
{
    //Capacity UI and Stats
    public Slider capacitySlider;
    public TextMeshProUGUI capacityText;
    public int capacity = 0;
    public int maxCapacity = 0;
    

    //score
    public static int currentScore;
    public static int totalScore;
    public TextMeshProUGUI scoreText;
    [SerializeField]private int scoreMultiplier;
    private SoundManager soundManager;
    [SerializeField] private Image exclamation_mark;
    public static int hitAmount;


    public GameObject explosionPrefab;

    void Start()
    {
        soundManager = GameObject.FindGameObjectWithTag("SoundManager").GetComponent<SoundManager>();
        if(capacitySlider){
        capacitySlider.maxValue = maxCapacity;
        }

        
    }

    void Update()
    {
        CapacitySliderUpdate();
    }
   

    private void OnGUI()
    {
        // GUI.Label(new Rect(10, 10, 100, 20), "Payload: " + payload + "/" + maxPayload);
        //TrashCollectionLabel.SetText("Collect pieces of space junk: " + capacity + "/" + maxCapacity);

         //if (capacity == maxCapacity)
        //{
         // this.gameObject.GetComponent<SpriteRenderer>().sprite = exclamation_mark;

       // }
    }

    private void CapacitySliderUpdate()
    {
        capacity = Mathf.Clamp(capacity, 0, maxCapacity);
        if(capacitySlider){
            capacitySlider.value = capacity;
        }
       
        if(capacityText){
            capacityText.text = capacity.ToString();
        }
        currentScore = capacity;

        if (capacity == maxCapacity)
        {
            Debug.Log("here");
            exclamation_mark.gameObject.SetActive(true);
        }

        else if(capacity != maxCapacity)
                {
            exclamation_mark.gameObject.SetActive(false);
        }

    }




    public void UpdateScore(){
        
        currentScore *= scoreMultiplier;
        totalScore += currentScore;
        scoreText.text = "Score:" + totalScore;
        
    }

    public void OnTriggerEnter(Collider other) {
        if (other.gameObject.tag == "Asteroid")
        { 
            soundManager.AsteroidCrash.Play();
            capacity--;
            Debug.Log("!!!!!!asteroid collision idk");
        }
    }

    public void OnCollisionEnter(Collision obj)
    {      
       
        if (obj.gameObject.tag == "Asteroid")
        {
            hitAmount++;
            soundManager.AsteroidCrash.Play();
            capacity--;
            Destroy(obj.gameObject,.1f);
            Debug.Log("asteroid collision idk");

            Instantiate(explosionPrefab, obj.transform.position, Quaternion.identity);
        }
        
    }
}
