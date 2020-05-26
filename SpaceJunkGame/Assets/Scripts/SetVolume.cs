using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public class SetVolume : MonoBehaviour
{
    public AudioMixer mixer;


    public void SetLevelMusic (float sliderValue)
    {
        mixer.SetFloat("MusicVol", Mathf.Log10(sliderValue) * 20);
    }

    public void SetLevelSFX (float sliderValueSFX)
    {
        mixer.SetFloat("SFXVol", Mathf.Log10(sliderValueSFX) * 20);
    }
}
