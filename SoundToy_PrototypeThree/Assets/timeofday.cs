using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class timeofday : MonoBehaviour
{
    public bool isNight = false;

    public Color dayCol;
    public Color nightCol;

    public Camera mainCam;
    
    public GameObject moonSprite;
    public GameObject sunSprite;
    
    // Update is called once per frame
    void Update()
    {
        if (isNight == true)
        {
            mainCam.backgroundColor = nightCol;
            sunSprite.SetActive(false);
            moonSprite.SetActive(true);
        }
        else
        {
            mainCam.backgroundColor = dayCol;
            sunSprite.SetActive(true);
            moonSprite.SetActive(false);
        }
    }

    private void OnMouseDown()
    {
        isNight = !isNight;
    }
}
