using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    protected float speed = 10;

    public GameObject explosionShootPrefab;


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
        if (collision.gameObject.tag == "Asteroid")
        {
            Debug.Log("asteroid hit with projectile");
            collision.gameObject.SetActive(false);
            Destroy(gameObject);
            Instantiate(explosionShootPrefab, gameObject.transform.position, Quaternion.identity);
        }
        
    }

     private void OnTriggerEnter(Collider other) {
        if(other.tag=="bigTrash")
        {
            other.GetComponent<TrashDestruction>().BigTrashDeath();
            Destroy(gameObject);
            Debug.Log("idk");
        }
    }
}
