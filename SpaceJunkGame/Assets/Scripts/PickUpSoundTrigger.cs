using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUpSoundTrigger : MonoBehaviour
{
    public AudioClip triggerSoundPickUp;
    AudioSource audiosource;
    
    void Start()
    {
        audiosource = GetComponent<AudioSource>();
    }

    
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (triggerSoundPickUp!=null)
        {
            audiosource.clip = triggerSoundPickUp;
            audiosource.Play();
        }
    }
}
