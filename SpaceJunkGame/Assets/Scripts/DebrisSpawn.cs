using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DebrisSpawn : MonoBehaviour
{
    float cont = 0f;
    float scroll;
    private void Update()
    {
        if (Input.GetKey(KeyCode.Mouse0))
        {
            scroll = 50;
            cont += scroll * Time.deltaTime;
        }
        else
        {
            scroll = 4;
            cont += scroll * Time.deltaTime;
        }

        if (cont >= 150) //edit to when scrolling text says how humanity didnt fix the space debris problem yet
        {
            print("SPAWN SPACE DEBRIS AROUND PLANET");
        }
    }
}
