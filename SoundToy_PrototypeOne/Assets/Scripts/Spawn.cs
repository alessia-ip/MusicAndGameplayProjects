using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour
{
   public GameObject chipPrefab;

   private void OnMouseDown()
   { 
       var newChip = Instantiate(chipPrefab); 
       newChip.transform.position = new Vector2(Camera.main.ScreenToWorldPoint(Input.mousePosition).x, Camera.main.ScreenToWorldPoint(Input.mousePosition).y);
   }
   
}
