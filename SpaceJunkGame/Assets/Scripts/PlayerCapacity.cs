using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerCapacity : MonoBehaviour
{
    public Slider slider;
    public Text text;

    void Start()
    {

    }
    void Update()
    {
        slider.value = gameObject.GetComponent<PlayerStats>().payload;
        text.text = "Capacity:" + gameObject.GetComponent<PlayerStats>().payload;
    }

}
