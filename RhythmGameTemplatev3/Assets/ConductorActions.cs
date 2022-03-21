using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConductorActions : MonoBehaviour
{
    public Sprite DownSprite;
    public Sprite UpSprite;
    
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            this.gameObject.GetComponent<SpriteRenderer>().sprite = DownSprite;
        }

        if (Input.GetKeyUp(KeyCode.R))
        {
            this.gameObject.GetComponent<SpriteRenderer>().sprite = UpSprite;

        }
    }
}
