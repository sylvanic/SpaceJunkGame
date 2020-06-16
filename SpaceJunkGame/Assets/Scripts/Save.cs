using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;



[Serializable]
public class Save
{
    public int scoreLevel1;
    public int scoreLevel2;
    public int scoreLevel3;

    public int highscore;

    public string playerName;
    public string playerGender;
    public string playerAge;


    public string chosenUpgrade;

    public int HasBooster;
    public int HasWeapon;
    public int HasCapacity;
    public int HasShield;
}

