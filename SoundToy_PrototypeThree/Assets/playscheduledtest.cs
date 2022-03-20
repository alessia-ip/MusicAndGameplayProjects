using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playscheduledtest : MonoBehaviour
{
    public AudioSource testAud;
    void Start()
    {
        testAud.PlayScheduled(5000d);
    }

    
}
