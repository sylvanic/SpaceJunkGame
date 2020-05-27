using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerCapacity : MonoBehaviour
{
    public float capacity;
    public Slider slider;
    public Text text;

    void Start()
    {
        
    }

    
    void Update()
    {
        slider.value = capacity;
        text.text = "Capacity:" + capacity;
    }
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Trash")
            capacity = capacity + 1f;
    }
}
