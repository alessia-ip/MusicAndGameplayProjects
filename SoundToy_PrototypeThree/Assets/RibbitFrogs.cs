using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Beat;
using UnityEngine.UI;

public class RibbitFrogs : MonoBehaviour
{
    public int frogNumberInRow;

    public int frogType;

    public GameObject frogSetOne;
    public GameObject frogSetTwo;
    public GameObject frogSetThree;

    public GameObject frogAudioOne;
    public GameObject frogAudioTwo;
    public GameObject frogAudioThree;

    public TickValue intervalBase;
    double intervalValue;
    double timeOfNextNote;
    public double intervalCount = 1d;

    public GameObject soundObject;

    public Slider slider;

    public Clock clockScript;

    private bool active = false;

    public timeofday _Timeofday;

    private bool flicker = false;
    
    void Start()
    {
        updateFrogAppearance();
        initFrogge();
    }

    public void initFrogge()
    {
        intervalValue = intervalCount * Clock.Instance.LengthOfD(intervalBase);
        timeOfNextNote = Clock.Instance.AtNext(intervalBase);
    }

    private void Update()
    {
        if (soundObject != null && soundObject.GetComponent<AudioSource>().isPlaying && !flicker)
        {
            flickerthefrogs();
            flicker = true;
        }
        
        intervalValue = intervalCount * Clock.Instance.LengthOfD(intervalBase);
        
        if (AudioSettings.dspTime >= timeOfNextNote)
        {
            //Debug.Log(clockScript.Beats);
            if (clockScript.Beats == frogNumberInRow - 1)
            {
                if (active != true) makeSound();
            } else
            {
                active = false;
            }
        }
        else
        {
            active = false;
        }
    }

    public void makeSound()
    {
        active = true;
        
        if (soundObject != null)
        {
            Destroy(soundObject);
        }
        
        switch (frogType)
        {
            case 0:
                timeOfNextNote += intervalValue;
                return;
            case 1:
                soundObject = Instantiate(frogAudioOne);
                break;
            case 2:
                soundObject = Instantiate(frogAudioTwo);
                break;
            case 3:
                soundObject = Instantiate(frogAudioThree);
                break;
        }
        
        AudioSource soundSource = soundObject.GetComponent<AudioSource>();
        timeOfNextNote += intervalValue;
        var sliderInt = slider.value;
        var newPitch = Remap(sliderInt, 0, 1, 0.5f, 3);
        soundSource.pitch = newPitch;
        if (_Timeofday.isNight)
        {
            soundSource.volume = 0.3f;
        }
        else
        {
            soundSource.volume = 0.7f;
        }
        //soundSource.PlayDelayed((float)timeOfNextNote);
        soundSource.PlayScheduled(timeOfNextNote);
        //Destroy(soundObject, (float)intervalValue + (soundSource.clip.length / Mathf.Abs(soundSource.pitch)) + 0.2f);
        //Invoke(nameof(flickerthefrogs), (float)timeOfNextNote);
        flicker = false;
    }

    void flickerthefrogs()
    {
        foreach(var frogge in GetComponentsInChildren<flickerFrog>())
        {
            frogge.flickerFrogOnce();
        }
    }
    
    public void changeFrogType()
    {
        frogType++;
        if (frogType == 4)
        {
            frogType = 0;
        }

        updateFrogAppearance();
    }

    public void updateFrogAppearance()
    {
        switch (frogType)
        {
            case 0:
                frogSetOne.SetActive(false);
                frogSetTwo.SetActive(false);
                frogSetThree.SetActive(false);
                return;
            case 1:
                frogSetOne.SetActive(true);
                frogSetTwo.SetActive(false);
                frogSetThree.SetActive(false);
                return;
            case 2:
                frogSetOne.SetActive(false);
                frogSetTwo.SetActive(true);
                frogSetThree.SetActive(false);
                return;
            case 3:
                frogSetOne.SetActive(false);
                frogSetTwo.SetActive(false);
                frogSetThree.SetActive(true);
                return;
        }
    }
    
    public static float Remap (float from, float fromMin, float fromMax, float toMin,  float toMax)
    {
        var fromAbs  =  from - fromMin;
        var fromMaxAbs = fromMax - fromMin;      
       
        var normal = fromAbs / fromMaxAbs;
 
        var toMaxAbs = toMax - toMin;
        var toAbs = toMaxAbs * normal;
 
        var to = toAbs + toMin;
       
        return to;
    }
    
}
