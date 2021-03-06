﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PermitTalking : MonoBehaviour
{
    public Transform crosshairs;
    public static bool AtTable;

    private void OnTriggerEnter()
    {
        GirlAnimations.IsInFront = true;
        crosshairs.GetComponent<Image>().enabled = true;
        AtTable = true;
    }

    private void OnTriggerExit()
    {
        GirlAnimations.IsInFront = false;
        crosshairs.GetComponent<Image>().enabled = false;
        AtTable = false;
    }
}
