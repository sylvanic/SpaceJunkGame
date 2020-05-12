using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStats : MonoBehaviour
{

    public int payload = 0;
    public int maxPayload = 3;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnGUI()
    {
        GUI.Label(new Rect(10, 10, 100, 20), "Payload: " + payload + "/10");
    }
}
