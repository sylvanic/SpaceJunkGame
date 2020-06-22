using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DisplayPlayerName : MonoBehaviour
{
    public static DisplayPlayerName instance;

    public static string playerUsername;
    private Text playersName;

    //public Text playerText;

    void Awake()
    {
        instance = this;
    }

    // Start is called before the first frame update
    void Start()
    {
        playerUsername = playersName.text;
    }  
}
