using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pickable : MonoBehaviour
{
    private SoundManager soundManager;
    public static int junkAmount;

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
                junkAmount++;
                soundManager.PickUp.Play();
                if(tag=="smallTrash")
                {
                other.GetComponent<PlayerStats>().capacity++;
                }
                else if(tag=="mediumTrash")
                {
                other.GetComponent<PlayerStats>().capacity+=5;
                }
                else if(tag=="bigTrash")
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
