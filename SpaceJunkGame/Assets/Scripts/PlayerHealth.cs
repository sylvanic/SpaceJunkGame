using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlayerHealth : MonoBehaviour
{
    public float health;
    public Slider slider;
    public Text text;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        slider.value = health;
        text.text = "HP:" + health;
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
            health = health - 10f;
        }
    }
}

