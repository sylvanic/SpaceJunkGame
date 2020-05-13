using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] float movementSpeed = 50f;
    [SerializeField] float turnSpeed = 60f;

    public Transform shootingPont;
    public Projectile projectile;

    Transform myT;

    private void Awake()
    {
        myT = transform;
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
    }

    void Turn()
    {
        float yaw = turnSpeed * Time.deltaTime * Input.GetAxis("Horizontal");

        myT.Rotate(0, yaw, 0);
    }

    void Shoot()
    {
        if (Input.GetKeyDown("space"))
        {
            Projectile newProjectile = Instantiate(projectile, shootingPont.position, shootingPont.rotation) as Projectile;
        }

    }
}
