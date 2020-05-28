﻿using System.Collections;
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
        if (SceneManager.GetActiveScene().name == "NEW_Menu")
        {
            Menu.Play();
        }
        else if (SceneManager.GetActiveScene().name == "Intro")
        {
            Cutscene.Play();

            Menu.Stop();
        }
        else if (SceneManager.GetActiveScene().name == "Tutorial Final")
        {
            Tutorial.Play();

            Cutscene.Stop();
        }
        else if (SceneManager.GetActiveScene().name == "GameTest")
        {
            InGame.Play();

            Tutorial.Stop();
        }
    }

}
