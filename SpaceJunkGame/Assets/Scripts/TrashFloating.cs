using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrashFloating : MonoBehaviour
{
    public float speed;


  
    void Update()
    {
        transform.Rotate(speed * Time.deltaTime, speed * Time.deltaTime, speed * Time.deltaTime);
    }
}
