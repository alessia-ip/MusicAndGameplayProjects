using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class flickerFrog : MonoBehaviour
{
    public GameObject openMouth;
    public GameObject closeMouth;

    public void flickerFrogOnce()
    {
        Debug.Log("flick!");
        openMouth.SetActive(true);
        closeMouth.SetActive(false);
        Invoke(nameof(flickerFrogTwice), 0.5f);
    }

    public void flickerFrogTwice()
    {
        openMouth.SetActive(false);
        closeMouth.SetActive(true);
    }
}
