using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EarthRotation : MonoBehaviour
{
    void Update()
    {
        transform.Rotate(0, 1*Time.deltaTime, 0);
    }
}
