using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PianoImgChange : MonoBehaviour
{
   public Sprite PianoOne;
   public Sprite PianoTwo;

   public SpriteRenderer sprRend;
   public void ChangeSprite()
   {
      if (sprRend.sprite == PianoOne)
      {
         sprRend.sprite = PianoTwo;
      }
      else
      {
         sprRend.sprite = PianoOne;
      }
   }
}
