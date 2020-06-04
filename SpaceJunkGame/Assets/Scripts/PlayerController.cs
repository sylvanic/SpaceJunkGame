using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField]public float movementSpeed = 50f;
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
        Shoot();
        
    }

    void Thrust()
    {
        myT.position += myT.forward * movementSpeed * Time.deltaTime * Input.GetAxis("Vertical");
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
        float yaw = turnSpeed * Time.deltaTime * Input.GetAxis("Horizontal");

        myT.Rotate(0, yaw, 0);

      
    }

    void Shoot()
    {
        if (Input.GetKeyDown("1"))
        {
            soundManager.Shoot.Play();
            Projectile newProjectile = Instantiate(projectile, shootingPont.position, shootingPont.rotation) as Projectile;
        }

    }
}
