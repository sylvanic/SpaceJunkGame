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
    public Text capacityText;
    public int capacity = 0;
    public int maxCapacity = 3;

    //Health UI and Stats
    public int health;
    public Slider healthSlider;
    public Text healthText;

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
        capacitySlider.value = capacity;
        capacityText.text = "Capacity:" + capacity;
    }

    private void HealthSliderUpdate()
    {
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
            health = health - 10;
        }
    }


}
