﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public Joystick joystick;
    [SerializeField] public float movementSpeed = 50f;
    [SerializeField] float turnSpeed = 60f;

    public Transform shootingPont;
    public Projectile projectile;
    public Projectile upgradedProjectile;
    private SoundManager soundManager;

    Transform myT;


    private void Awake()
    {
        myT = transform;
        soundManager = GameObject.FindGameObjectWithTag("SoundManager").GetComponent<SoundManager>();
    }
    private void Update()
    {
        Turn();
        Thrust();
     
    }

    void Thrust()
    {

        if(joystick.Vertical>=.2f){
            myT.position += myT.forward*movementSpeed*Time.deltaTime;
        }

        //myT.position += myT.forward * movementSpeed * Time.deltaTime * joystick.Vertical;

        soundManager.RocketEngine.pitch *= Input.GetAxis("Vertical");
        if (Input.GetKeyDown(KeyCode.W))
        {
            soundManager.RocketEngine.Play();
            soundManager.RocketEngine.loop = true;        

        }

        if (Input.GetKeyUp(KeyCode.W))
        {
            soundManager.RocketEngine.Stop();



        }
    }

    void Turn()
    {
        float yaw = turnSpeed * Time.deltaTime * joystick.Horizontal;

        myT.Rotate(0, yaw, 0);


    }

    public void Shoot()
    {
        
            soundManager.Shoot.Play();
            Projectile newProjectile = Instantiate(projectile, shootingPont.position, shootingPont.rotation) as Projectile;
        
    }
}
