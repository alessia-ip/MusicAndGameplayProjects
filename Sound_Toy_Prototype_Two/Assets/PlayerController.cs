using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor.UIElements;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public Rigidbody playerRigidbody;
    private float speed = 0.1f;
    
    
    
    public PositionToPitch posToPitch;
    
    [Header("only required when using synth")]
    public pxStrax Synth;
    public float minSynthParam = 100;
    public float maxSynthParam = 12000;
    public AnimationCurve mappingCurve = AnimationCurve.Linear(0f, 0f, 1f, 1f);


    public GameObject spriteImg;
    

    public AudioSource aSource;
    public Animator anim;
    
    public void Update()
    {
        if (Input.GetKey(KeyCode.UpArrow))
        {
            playerRigidbody.AddForce(Vector3.forward * speed, ForceMode.VelocityChange);
            anim.SetBool("isWalking", true);
        } else if (Input.GetKey(KeyCode.DownArrow))
        {
            playerRigidbody.AddForce(Vector3.back * speed, ForceMode.VelocityChange);
            anim.SetBool("isWalking", true);
        } else if (Input.GetKey(KeyCode.LeftArrow))
        {
            playerRigidbody.AddForce(Vector3.left * speed, ForceMode.VelocityChange);
            anim.SetBool("isWalking", true);
            spriteImg.GetComponent<SpriteRenderer>().flipX = true;
        } else if (Input.GetKey(KeyCode.RightArrow))
        {
            playerRigidbody.AddForce(Vector3.right * speed, ForceMode.VelocityChange);
            anim.SetBool("isWalking", true);
            spriteImg.GetComponent<SpriteRenderer>().flipX = false;
        }
        else
        {
            anim.SetBool("isWalking", false);
            playerRigidbody.velocity = Vector3.zero;
        }
        
        //aSource.pitch = posToPitch.PitchMapping(transform.position);
        //Debug.Log(posToPitch.PitchMapping(transform.position));
        
        Synth.sustain = true;
        posToPitch.sendMidi = true;
        Synth.KeyOn(posToPitch.PitchMapping(new Vector2(this.transform.position.x, this.transform.position.z)));

        
//        Debug.Log("synth pitch: " + posToPitch.PitchMapping(new Vector2(this.transform.position.x, this.transform.position.z)));
    }
    
    
}
