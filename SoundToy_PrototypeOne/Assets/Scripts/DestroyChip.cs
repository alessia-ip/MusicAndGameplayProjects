using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyChip : MonoBehaviour
{
   
   public AudioClip SoundOne;
   public AudioClip SoundTwo;

   public Color colOne;
   public Color colTwo;
   
   public bool soundOne;

   private void Start()
   {
      if (soundOne)
      {
         this.gameObject.GetComponent<SpriteRenderer>().color = colOne;
      }
      else
      {
         this.gameObject.GetComponent<SpriteRenderer>().color = colTwo;
      }
   }

   private void OnMouseDown()
   {
      soundOne = !soundOne;
      if (soundOne)
      {
         this.gameObject.GetComponent<SpriteRenderer>().color = colOne;
      }
      else
      {
         this.gameObject.GetComponent<SpriteRenderer>().color = colTwo;
      }
   }
   

   private void OnCollisionEnter2D(Collision2D other)
   {
      other.gameObject.transform.GetChild(0).transform.parent = null;
      Destroy(other.gameObject);
      if (soundOne)
      {
         this.gameObject.GetComponent<AudioSource>().PlayOneShot(SoundOne);
      }
      else
      {
         this.gameObject.GetComponent<AudioSource>().PlayOneShot(SoundTwo);
      }
      this.gameObject.GetComponentInChildren<ParticleSystem>().Play();

   }
   
}
