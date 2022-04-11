using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class turnSelfOff : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            this.gameObject.SetActive(false);
        }  
    }
}
