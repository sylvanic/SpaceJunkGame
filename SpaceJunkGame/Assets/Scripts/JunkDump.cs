﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class JunkDump : MonoBehaviour
{
    public int junkDumped = 0;
    public int maxJunkDumped = 0;
    public TextMeshProUGUI TrashDisposalLabel;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        TrashDisposalLabel.SetText("Dump collected space junk: " + junkDumped + "/" + maxJunkDumped);
       // WinCondition();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            junkDumped = other.GetComponent<PlayerStats>().capacity;
            other.GetComponent<PlayerStats>().capacity = 0;
            other.GetComponent<PlayerStats>().UpdateScore();
            Debug.Log(other.GetComponent<PlayerStats>().currentScore);
        }
    }

    void WinCondition()
    {
        if (junkDumped >= maxJunkDumped)
        {
            SceneManager.LoadScene("Cutscene1");
        }
    }
}
