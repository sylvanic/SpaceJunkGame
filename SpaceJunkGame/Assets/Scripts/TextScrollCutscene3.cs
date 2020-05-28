using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TextScrollCutscene3 : MonoBehaviour
{
    float cont = 0;
    float scroll;
    void Update()
    {
        if (Input.GetKey(KeyCode.Mouse0))
        {
            scroll = 50;
            transform.Translate(0, scroll * Time.deltaTime, 0);
            cont += scroll * Time.deltaTime;

        }
        else
        {
            scroll = 4;
            transform.Translate(0, scroll * Time.deltaTime, 0);
            cont += scroll * Time.deltaTime;
        }

        if (cont >= 300)
        {
            cont = 0;
            //PLACE NEXT SCENE HERE: LEVEL MAIN MENU SCENE

        }
    }
}
