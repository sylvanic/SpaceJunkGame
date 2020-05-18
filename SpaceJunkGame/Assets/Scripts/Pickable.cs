using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pickable : MonoBehaviour
{

    void Start()
    {

    }

    void Update()
    {

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            if (other.GetComponent<PlayerStats>().capacity < other.GetComponent<PlayerStats>().maxCapacity)
            {
                other.GetComponent<PlayerStats>().capacity++;
                Destroy(gameObject);
            }
        }
    }
}
