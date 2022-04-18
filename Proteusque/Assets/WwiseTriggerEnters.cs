using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using AK.Wwise;

public class WwiseTriggerEnters : MonoBehaviour
{

    public AK.Wwise.Event wwiseEvent;
    public AK.Wwise.Event wwiseEvent2;
    
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            Debug.Log("player enter");
            wwiseEvent.Post(gameObject);
        }
    }
    
    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
        {
            wwiseEvent2.Post(gameObject);
        }
    }
}
