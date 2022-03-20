using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collisions : MonoBehaviour
{

    public int numberOfGhosts = 0;

    public int RedGhosts;
    
    public pxStrax Synth;


   
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name.Contains("Ghost"))
        {
            numberOfGhosts++;
        }
        
        if (other.CompareTag("RedGhost"))
        {
            RedGhosts++;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.name.Contains("Ghost"))
        {
            numberOfGhosts--;
        }

        if (other.CompareTag("RedGhost"))
        {
            RedGhosts--;
        }
    }

    private void Update()
    {
        if (RedGhosts == 0)
        {
            Synth.osc2Mix = 0.1f;
           Synth.volume = 0.2f;
        } else if(RedGhosts > 0 || RedGhosts <=2)
        {
            Synth.osc2Mix = 1;
           Synth.volume = 0.7f;
        } else if (RedGhosts > 2)
        {
            Synth.osc2Mix = 2;
           Synth.volume = 0.7f;
        }
        
        if (numberOfGhosts == 0) return;
        
        float feedbackAmt = numberOfGhosts / 5f;

        float newAmp = 0.1f + feedbackAmt / 2;
        float newRate = 1.5f + feedbackAmt * 2;
        if (newAmp > 1f)
        {
            newAmp = 1f;
        }

        if (newRate > 10f)
        {
            newRate = 10f;
        }
        /*Synth.lfoAmp = 0.1f + newAmp;*/
        Synth.lfoRate = 1.5f + newRate;


    }
}
