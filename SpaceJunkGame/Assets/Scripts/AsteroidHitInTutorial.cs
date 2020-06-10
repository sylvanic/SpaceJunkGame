using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AsteroidHitInTutorial : MonoBehaviour
{
    public TutorialInteraction tutInt;

    public void OnCollisionEnter(Collision obj)
    {
        if (obj.gameObject.tag == "Asteroid")
        {
            tutInt.hitByAsteroid = true;
        }
    }
}
