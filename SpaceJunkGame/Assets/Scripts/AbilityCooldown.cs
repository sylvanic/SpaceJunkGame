using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Image))]
[RequireComponent(typeof(Button))]
public class AbilityCooldown : MonoBehaviour
{
    private Image abilityImage;
    private Button button;
    [SerializeField]private float cooldown;
    private bool coolingDown;
    private bool isPressed;
    void Start()
    {
        abilityImage = GetComponent<Image>();
        button = GetComponent<Button>();
        coolingDown = false;
    }

    // Update is called once per frame
    void Update()
    {
        
        if (coolingDown == true)
        {
            abilityImage.fillAmount -= 1.0f / cooldown * Time.deltaTime;
            button.interactable=false;
            
            if(abilityImage.fillAmount<=0){
                abilityImage.fillAmount=1;
                coolingDown=false;
                button.interactable=true;
            }
            
        }
    }

    public void GetClicked(){
        if(coolingDown!=true)
        {
            coolingDown = true;
        }
    }
}
