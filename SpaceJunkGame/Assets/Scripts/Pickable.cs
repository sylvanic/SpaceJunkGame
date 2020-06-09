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
                if(this.tag=="smallTrash")
                {
                other.GetComponent<PlayerStats>().capacity++;
                }
                else if(this.tag=="mediumTrash")
                {
                other.GetComponent<PlayerStats>().capacity+=5;
                }
                else if(this.tag=="bigTrash")
                {
                    other.GetComponent<PlayerStats>().capacity+=10;
                }
                Destroy(gameObject);
            }
            else{

                //full sound and message
                Debug.Log("ok");
            }
        }
    }
}
