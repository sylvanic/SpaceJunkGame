using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public Joystick joystick;
    [SerializeField] public float movementSpeed = 50f;
    [SerializeField] float turnSpeed = 60f;

    public Transform shootingPont;
    [SerializeField] private float cooldownTime;
    private bool onCooldown;
    public Projectile projectile;  

    public Projectile currentProjectile;
    public Projectile upgradedProjectile;
    private SoundManager soundManager;

    Transform myT;


    private void Awake()
    {
        currentProjectile = projectile;
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
        //get the directional vector of the joystic
      
        if(Mathf.Abs(joystick.Vertical) >= .2f || Mathf.Abs(joystick.Horizontal) >= .2f){
            Vector3 v = new Vector3(joystick.Direction.x, 0.0f, joystick.Direction.y);
            Debug.DrawRay(transform.position, v * 10.0f, Color.red);  
            transform.rotation =  Quaternion.LookRotation(v);
            myT.position += myT.forward*movementSpeed*Time.deltaTime;
            if(!soundManager.RocketEngine.isPlaying)
            {
                soundManager.RocketEngine.Play();
                soundManager.RocketEngine.loop = true;
            }
        }else{
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
            if(onCooldown == false)
            {
            soundManager.Shoot.Play();
            Projectile newProjectile = Instantiate(currentProjectile, 
                                                   shootingPont.position, 
                                                   shootingPont.rotation) as Projectile;   
            
            onCooldown = true;
            StartCoroutine(ShootingCooldown(cooldownTime));
            }                                                 
    }
    IEnumerator ShootingCooldown(float waitTime){
            yield return new WaitForSeconds(waitTime);
            onCooldown = false;
    } 
}
