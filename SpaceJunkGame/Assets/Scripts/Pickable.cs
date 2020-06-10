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
                
                if(this.tag=="smallTrash")
                {
                other.GetComponent<PlayerStats>().capacity++;
                Destroy(gameObject);
                soundManager.PickUp.Play();
                }
                else if(tag=="mediumTrash")
                {
                other.GetComponent<PlayerStats>().capacity+=5;
                Destroy(gameObject);
                soundManager.PickUp.Play();
                }
                
            }
            else{

                //full sound and message
                Debug.Log("ok");
            }
        }
    }
}
