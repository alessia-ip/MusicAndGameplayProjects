using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class clink : MonoBehaviour
{
    public AudioSource clinkSource;
    public AudioClip clinkClip;

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.name.Contains("CircleChip"))
        {
            clinkSource.PlayOneShot(clinkClip);
        }
    }
}
