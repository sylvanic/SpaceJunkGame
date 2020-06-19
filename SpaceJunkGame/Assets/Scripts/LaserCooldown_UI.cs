using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LaserCooldown_UI : MonoBehaviour
{
    public Image imageCooldown;
    public float cooldown = 5;
    bool isCooldown = false;
    public bool isTriggered = false;

    // Update is called once per frame
   private void Awake() {
       isTriggered=false;
   }
    void Update()
    {
        if (isTriggered)
        {
            isCooldown = true;
            isTriggered=false;
        }
        if (isCooldown)
        {
            imageCooldown.fillAmount -= 1 / cooldown * Time.deltaTime;

            if (imageCooldown.fillAmount <= 0)
            {
                imageCooldown.fillAmount = 1;
                isCooldown = false;
            }
        }
    
    }


}
