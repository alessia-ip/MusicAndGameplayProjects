using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PegSetActive : MonoBehaviour
{
    public AudioClip switchSnd;
    
    private void OnMouseDown()
    {
        this.gameObject.GetComponent<Collider2D>().isTrigger = !this.gameObject.GetComponent<Collider2D>().isTrigger;
        if (gameObject.GetComponent<Collider2D>().isTrigger)
        {
            this.gameObject.GetComponent<SpriteRenderer>().color = Color.gray;
        }
        else
        {
            this.gameObject.GetComponent<SpriteRenderer>().color = Color.white;
        }
        this.gameObject.GetComponent<AudioSource>().PlayOneShot(switchSnd);
    }
}
