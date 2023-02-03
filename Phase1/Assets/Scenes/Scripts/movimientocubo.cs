using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movimientocubo : MonoBehaviour
{
    public float speed = 10.0f;
    private bool isPaused = false;
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.P))
        {
            if (isPaused)
            {
                
                PlayVideo();
                
            }
            else
            {
                PauseVideo();
                
            }
        }
    }

    public void PauseVideo()
    {

        transform.position += transform.forward * speed * Time.deltaTime;
        isPaused = true;
    }

    public void PlayVideo()
    {
        transform.position -= transform.forward * (speed) * Time.deltaTime;  
        isPaused = false;
    }
}
