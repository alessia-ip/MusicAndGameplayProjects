using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tunings : MonoBehaviour
{

    public float defaultTune;
    public float tuningOne;
    public float tuningTwo;

    public float defaultCut;
    public float cutOne;
    public float cutTwo;
    
    public pxStrax strax;

    public void tuneScanner(int tuningValue)
    {
        switch (tuningValue)
        {
            case 1:
                strax.envelope = defaultTune;
                return;
            case 2:
                strax.envelope = tuningOne;
                return;
            case 3:
                strax.envelope = tuningTwo;
                return;
            case 4:
                strax.cutoff = defaultCut;
                return;
            case 5:
                strax.cutoff = cutOne;
                return;
            case 6:
                strax.cutoff = cutTwo;
                return;
            default:
                return;
        }
    }
}
