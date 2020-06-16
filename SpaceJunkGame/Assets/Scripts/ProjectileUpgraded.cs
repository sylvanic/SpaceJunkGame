﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileUpgraded : Projectile
{
    // Start is called before the first frame update
    private void Start()
    {

    }
    void Update()
    {
        transform.Translate(Vector3.forward * Time.deltaTime * speed);
        Destroy(gameObject, 5);
    }

    private void OnTriggerEnter(Collider other) {
        
        if(other.gameObject.tag=="Asteroid")
        {
            Destroy(other.gameObject);
        }
    }
}
