using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaterSwap : MonoBehaviour
{
    
    bool HasTriggered = false;

    private float pHeight = 0.93f;

    public AK.Wwise.Event goUnderWater;
    public AK.Wwise.Event goAboveWater;
    
    
    // Update is called once per frame
    void Update()
    {
        if (!HasTriggered && transform.position.y >= pHeight)
        {
            HasTriggered = true;
            goAboveWater.Post(gameObject);
            Debug.Log("Above");

        } else if (HasTriggered && transform.position.y < pHeight)
        {
            
            HasTriggered = false;
            goUnderWater.Post(gameObject);
            Debug.Log("Under");
        }
    }
}
