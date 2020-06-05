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
    }

    private void CapacitySliderUpdate()
    {
        capacity = Mathf.Clamp(capacity, 0, maxCapacity);
        capacitySlider.value = capacity;
        capacityText.text = capacity.ToString();
        currentScore = capacity;
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
