using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HelpMenu : MonoBehaviour
{
    public GameObject HintButton;
    public GameObject MenuPage1;
    public GameObject MenuPage2;
    public GameObject MenuPage3;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void CloseMenu()
    {
        HintButton.SetActive(true);
    }

    public void OpenMenu()
    {
        HintButton.SetActive(false);
        MenuPage1.SetActive(true);
    }

    public void GoToPage1fromPage2()
    {
        MenuPage2.SetActive(false);
        MenuPage1.SetActive(true);
    }

    public void GoToPage2fromPage1()
    {
        MenuPage1.SetActive(false);
        MenuPage2.SetActive(true);
    }

    public void GoToPage3fromPage2()
    {

    }

    public void GoToPage2fromPage3()
    {

    }
}
