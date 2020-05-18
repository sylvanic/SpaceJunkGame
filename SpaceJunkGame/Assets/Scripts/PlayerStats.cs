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

    //Health UI and Stats
    public int health;
    public Slider healthSlider;
    public TextMeshProUGUI healthText;

    void Start()
    {

    }

    void Update()
    {
        CapacitySliderUpdate();
        HealthSliderUpdate();
    }

    private void OnGUI()
    {
        // GUI.Label(new Rect(10, 10, 100, 20), "Payload: " + payload + "/" + maxPayload);
        TrashCollectionLabel.SetText("Collect pieces of space junk: " + capacity + "/" + maxCapacity);
    }

    private void CapacitySliderUpdate()
    {
        capacity = Mathf.Clamp(capacity, 0, maxCapacity);
        capacitySlider.value = capacity;
        capacityText.text = "Capacity:" + capacity;
    }

    private void HealthSliderUpdate()
    {
        health = Mathf.Clamp(health, 0, 100);
        healthSlider.value = health;
        healthText.text = "HP:" + health;
    }

    void OnCollisionEnter(Collision obj)
    {
        if (health <= 0)
        {
            health = 0;
            SceneManager.LoadScene("AudioTestScene");
        }
        else if (obj.gameObject.tag == "Asteroid")
        {
            capacity--;
            health = health - 10;
        }
    }


}
