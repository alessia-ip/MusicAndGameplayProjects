using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveToOgPos : MonoBehaviour
{
    public Vector3 og;
    
    // Start is called before the first frame update
    void Start()
    {
        og = this.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        if (this.transform.position != og)
        {
            move();
        }
    }

    void move()
    {
        this.transform.position = Vector3.Lerp(this.transform.position, og, Time.deltaTime * 0.03f);
    }
    
    
}
