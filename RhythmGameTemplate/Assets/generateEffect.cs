using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class generateEffect : MonoBehaviour
{

    public Text rank;
    public ParticleSystem particle_;

    public InputEvaluator score;
    
    // Update is called once per frame
    public void UpdateEffectText(string Timing)
    {
        CancelInvoke();
        particle_.Stop();   
        rank.text = Timing;
        rank.gameObject.SetActive(true);
        if (Timing.Contains("Perfect") || Timing.Contains("Good"))
        {
            particles();
        }
        Invoke(nameof(effectTextOff), 1f);
    }

    public void particles()
    {
        particle_.Play();   
    }
    
    public void EndLevel()
    {
        CancelInvoke();
        rank.text = "Score: " + score.gameScore.ToString();
        rank.gameObject.SetActive(true);
    }
    
    public void effectTextOff()
    {
        rank.gameObject.SetActive(false);
    }
}
