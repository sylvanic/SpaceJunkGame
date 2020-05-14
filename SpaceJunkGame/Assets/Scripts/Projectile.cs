using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    float speed = 10;


    private void Start()
    {

    }
    void Update()
    {
        transform.Translate(Vector3.forward * Time.deltaTime * speed);
        Destroy(gameObject, 5);
    }

    private void OnCollisionEnter(Collision collision)
    {
        foreach (ContactPoint contact in collision.contacts)
        {
            Debug.Log("ree");
        }
    }
}
