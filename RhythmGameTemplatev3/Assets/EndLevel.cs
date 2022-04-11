using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndLevel : MonoBehaviour
{
    private bool canRestart = false;
    public GameObject endText;
    
    // Update is called once per frame
    void Update()
    {
        if (canRestart)
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                SceneManager.LoadScene(0);
            }
        }
    }

    public void endLevelHandler()
    {
        canRestart = true;
        endText.SetActive(true);
        
    }
}
