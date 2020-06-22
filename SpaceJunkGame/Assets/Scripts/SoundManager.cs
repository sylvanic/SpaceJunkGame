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
    public AudioSource TimerSound;
    public AudioSource CapacityFull;
    public AudioSource ChallengeCompleted;

    [Header("Level")]
    public AudioSource LevelComplete;
    public AudioSource LevelFail;

}
