using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IgnoreAudioSourceOff : MonoBehaviour
{
    public AudioSource ignoreOff;
    
    // Start is called before the first frame update
    void Start()
    {
        ignoreOff.ignoreListenerPause = true;
    }

    
}
