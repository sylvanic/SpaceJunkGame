using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SaveUpgrade : MonoBehaviour
{
    private bool created = false;
    //private GameObject player;
    private void Awake()
    {
       // player = GameObject.FindGameObjectWithTag("Player");

        if (!created)
        {
            DontDestroyOnLoad(gameObject);
            created = false;
        }
        else
        {
            Destroy(this.gameObject);
        }
        
    }
}
