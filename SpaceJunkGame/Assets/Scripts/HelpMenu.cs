using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HelpMenu : MonoBehaviour
{
    public GameObject HintButton;
    public GameObject CloseButton;
    public GameObject MenuPage1;
    public GameObject MenuPage2;
    public GameObject MenuPage3;
    public GameObject MenuPage4;
    public GameObject MenuPage5;
    public GameObject weapon;
    public GameObject capacity;
    public GameObject immunity;
    public GameObject weaponNL;
    public GameObject capacityNL;
    public GameObject immunityNL;

    public void CloseMenu()
    {
        HintButton.SetActive(true);
        CloseButton.SetActive(false);
        MenuPage1.SetActive(false);
        MenuPage2.SetActive(false);
        MenuPage3.SetActive(false);
        MenuPage4.SetActive(false);
        MenuPage5.SetActive(false);
    }

    public void OpenMenu()
    {
        HintButton.SetActive(false);
        CloseButton.SetActive(true);
        MenuPage1.SetActive(true);
    }

    public void GoToPage1fromPage2()
    {
        MenuPage2.SetActive(true);
        MenuPage1.SetActive(false);
    }

    public void GoToPage2fromPage1()
    {
        MenuPage2.SetActive(false);
        MenuPage1.SetActive(true);
    }

    public void GoToPage3fromPage2()
    {
        MenuPage3.SetActive(false);
        MenuPage2.SetActive(true);
    }

    public void GoToPage2fromPage3()
    {
        MenuPage3.SetActive(true);
        MenuPage2.SetActive(false);
    }

    public void GoToPage4fromPage3()
    {
        MenuPage3.SetActive(false);
        MenuPage4.SetActive(true);
        if (LangSwitchBool.englishTxt)
        {
            weapon.SetActive(true);
        }
        else
        {
            weaponNL.SetActive(true);
        }
    }

    public void GoToPage3fromPage4()
    {
        MenuPage3.SetActive(true);
        MenuPage4.SetActive(false);
        weapon.SetActive(false);
        weaponNL.SetActive(false);
    }

    public void GoToPage5fromPage4()
    {
        MenuPage4.SetActive(false);
        MenuPage5.SetActive(true);
        weapon.SetActive(false);
        weaponNL.SetActive(false);
        if (LangSwitchBool.englishTxt)
        {
            immunity.SetActive(true);
            capacity.SetActive(true);
        }
        else
        {
            immunityNL.SetActive(true);
            capacityNL.SetActive(true);
        }

    }

    public void GoToPage4fromPage5()
    {
        MenuPage4.SetActive(true);
        MenuPage5.SetActive(false);
        immunity.SetActive(false);
        capacity.SetActive(false);
        immunityNL.SetActive(false);
        capacityNL.SetActive(false);
        if (LangSwitchBool.englishTxt)
        {
            weapon.SetActive(true);
        }
        else
        {
            weaponNL.SetActive(true);
        }
    }
}
