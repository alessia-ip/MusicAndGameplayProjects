using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Billboard : MonoBehaviour
{
  

    // Update is called once per frame
    void Update()
    {
        var position = new Vector3(Camera.main.transform.position.x, this.transform.position.y, Camera.main.transform.position.z);
        transform.LookAt(position);
        
    }
}
