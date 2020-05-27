using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pickable : MonoBehaviour
{
    public AudioClip triggerSoundPickUp;
    AudioSource audiosource;
    void Start()
    {
        audiosource = GetComponent<AudioSource>();
        audiosource.clip = triggerSoundPickUp;
    }

    void Update()
    {

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.GetComponent<PlayerStats>().payload < other.GetComponent<PlayerStats>().maxPayload && other.tag == "Player")
        {
            Debug.Log("vnjs");
            audiosource.Play();
            other.GetComponent<PlayerStats>().payload++;
            Destroy(gameObject);
        }

    }
}
