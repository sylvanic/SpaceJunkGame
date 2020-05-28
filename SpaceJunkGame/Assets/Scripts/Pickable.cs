using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pickable : MonoBehaviour
{
    private SoundManager soundManager;

    void Start()
    {
        soundManager = GameObject.FindGameObjectWithTag("SoundManager").GetComponent<SoundManager>();
    }

    void Update()
    {

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            if (other.GetComponent<PlayerStats>().capacity < other.GetComponent<PlayerStats>().maxCapacity)
            {
                soundManager.PickUp.Play();
                other.GetComponent<PlayerStats>().capacity++;
                Destroy(gameObject);
            }
        }
    }
}
