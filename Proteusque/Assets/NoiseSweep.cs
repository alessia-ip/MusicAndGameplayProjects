using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NoiseSweep : MonoBehaviour
{
    private bool sweep = true;
    private bool canTrigger = true;
    [SerializeField]
    private float triggerTimer;
    public AK.Wwise.Event wwiseEvent;
    public AK.Wwise.Event wwiseEvent2;
    
    
    // Update is called once per frame
    void Update()
    {
        if (!sweep) return;
       
        if (!canTrigger)
        {
            triggerTimer = triggerTimer -= Time.deltaTime;

            if (triggerTimer <= 0)
            {
                canTrigger = true;
            }
            
        }
        else
        {
            wwiseEvent.Post(gameObject);
            canTrigger = false;
            GetNewTime();
            Invoke(nameof(StopSweep), 2);
        }
        
    }

    public void StopSweep()
    {
        wwiseEvent2.Post(gameObject);
    }
    
    public void GetNewTime()
    {
        var newTime = Random.Range(10, 60);
        triggerTimer = newTime;
    }
    
    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            sweep = true;
        }
    }
    
    
    void OnTriggerStay(Collider other)
    {
        if (other.tag == "Player")
        {
            sweep = true;
        }
    }
    
    void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
        {
            sweep = false;
        }
    }
    
}
