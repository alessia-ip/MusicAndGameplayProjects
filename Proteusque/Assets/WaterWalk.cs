using System.Collections;
using System.Collections.Generic;
using StarterAssets;
using UnityEngine;

public class WaterWalk : MonoBehaviour
{

    private float pHeight = 0.93f;

    public GameObject PlayerCapsule;
    
    public AK.Wwise.Event Walking;
    public AK.Wwise.Event NotWalking;

    public FirstPersonController controller;

    private bool inWater = true;

    private bool triggered = false;
    
    // Update is called once per frame
    void Update()
    {
        if (controller._speed > 0 && inWater)
        {
                if (PlayerCapsule.transform.position.y >= pHeight && !triggered)
                {
                    triggered = true;
                    Walking.Post(gameObject);
                }else if (PlayerCapsule.transform.position.y < pHeight)
                {
                    triggered = false;
                    NotWalking.Post(gameObject);
                }

        }
        else if (controller._speed == 0 || !inWater)
        {
            triggered = false;
            NotWalking.Post(gameObject);
        }
    }
    
    private void OnTriggerEnter(Collider other)
    {
        if (other.name.Contains("green"))
        {
            
            inWater = true;
        }
    }
    
    private void OnTriggerStay(Collider other)
    {
        if (other.name.Contains("green"))
        {
            
            inWater = true;
        }
    }
    
    private void OnTriggerExit(Collider other)
    {
        if (other.name.Contains("green"))
        {
            Debug.Log("leave water");
            inWater = false;
        }
    }
    
}
