using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SoundManager : MonoBehaviour
{

    [Header("BackgroundMusic")]
    public AudioSource InGame;
    public AudioSource Cutscene;
    public AudioSource Tutorial;
    public AudioSource Menu;

    [Header("Sound Effects")]
    public AudioSource PickUp;
    public AudioSource DropItem;
    public AudioSource Shoot;
    public AudioSource Stunned;
    public AudioSource AsteroidCrash;
    public AudioSource UpgradeUnlocked;
    public AudioSource DropOffStation;
    public AudioSource Hint;
    public AudioSource RocketEngine;

    [Header("UI & HUD")]
    public AudioSource MinimapRadar;
    public AudioSource TimerBuzzer;
    public AudioSource CapacityFull;
    public AudioSource ChallengeCompleted;

    [Header("Level")]
    public AudioSource LevelComplete;
    public AudioSource LevelFail;

    private void Start()
    {
        if (SceneManager.GetActiveScene().name == "NEW_Menu" || SceneManager.GetActiveScene().name == "SelectLevel")
        {
            Menu.Play();
        }

        else if (SceneManager.GetActiveScene().name == "Intro" || 
                 SceneManager.GetActiveScene().name == "Lvl1Cutscene" || 
                 SceneManager.GetActiveScene().name == "Lvl2Cutscene")
        {
            Cutscene.Play();
        }

        else if (SceneManager.GetActiveScene().name == "TutorialF")
        {
            Tutorial.Play();
        }

        else if (SceneManager.GetActiveScene().name == "GameTest")
        {
            InGame.Play();
        }
    }

}
