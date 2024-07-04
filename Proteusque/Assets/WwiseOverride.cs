using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using AK.Wwise;

public class WwiseOverride : MonoBehaviour
{

    public AK.Wwise.State startState;
    public AK.Wwise.Event startEvt;
    
    // Start is called before the first frame update
    void Start()
    {
        startState.SetValue();
        startEvt.Post(gameObject);

    }
    
}
