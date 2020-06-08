using System.Collections;
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
    public int maxCapacity = 3;
    

    //score
    public static int currentScore;
    public static int totalScore;
    public TextMeshProUGUI scoreText;
    [SerializeField]private int scoreMultiplier;

    private SoundManager soundManager;
    //private Sprite exclamation_mark;

    void Start()
    {
        soundManager = GameObject.FindGameObjectWithTag("SoundManager").GetComponent<SoundManager>();
        capacitySlider.maxValue = maxCapacity;
        
        
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
        if(capacity >= maxCapacity)
        {
            soundManager.CapacityFull.Play();
        }
        else
        {
        capacitySlider.value = capacity;
        capacityText.text = capacity.ToString();
        currentScore = capacity;
        }


//play CapacityFull SFX if the capacity bar is full
       // if (currentScore == maxCapacity)
        //{
          //  soundManager.CapacityFull.Play();
       // }
    }
    
       
    

    public void UpdateScore(){
        
        currentScore *= scoreMultiplier;
        totalScore += currentScore;
        scoreText.text = "Score:" + totalScore;
        
    }

    public void OnCollisionEnter(Collision obj)
    {      
        if (obj.gameObject.tag == "Asteroid")
        {
            soundManager.AsteroidCrash.Play();
            capacity--;
                             
            Destroy(obj.gameObject,.2f);
        }
    }
}
