using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class onClick : MonoBehaviour
{

    public RibbitFrogs changeFrog;
    
    private void OnMouseDown()
    {
        changeFrog.changeFrogType();
    }
}
