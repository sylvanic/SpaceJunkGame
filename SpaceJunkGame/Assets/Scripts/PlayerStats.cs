using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;


public class PlayerStats : MonoBehaviour
{

    //Capacity UI and Stats
    public TextMeshProUGUI TrashCollectionLabel;
    public Slider capacitySlider;
    public TextMeshProUGUI capacityText;
    public int capacity = 0;
    public int maxCapacity = 3;

    //score
    public int currentScore;
    public TextMeshProUGUI scoreText;
    [SerializeField]private int scoreMultiplier;

    private SoundManager soundManager;

    void Start()
    {
        soundManager = GameObject.FindGameObjectWithTag("SoundManager").GetComponent<SoundManager>();
    }

    void Update()
    {
       // CapacitySliderUpdate();
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
        capacityText.text = "Capacity:" + capacity;
        currentScore = capacity;
    }

    public void UpdateScore(){
        
        currentScore *= scoreMultiplier;
        scoreText.text = "Score:" + currentScore;
    }

    void OnCollisionEnter(Collision obj)
    {
        if (obj.gameObject.tag == "Asteroid")
        {
            soundManager.AsteroidCrash.Play();
            capacity--;

            Destroy(obj.gameObject,.2f);
        }
    }


}
