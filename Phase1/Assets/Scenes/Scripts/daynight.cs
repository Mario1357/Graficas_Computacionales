using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class daynight : MonoBehaviour
{
    public float min, grados;
    public float timespeed = 100;

    // Update is called once per frame
    void Update()
    {
        min += timespeed * Time.deltaTime; 
        if (min >= 1440){
            min = 0;
        }        
        grados = min / 4;
        this.transform.localEulerAngles = new Vector3(grados, -45f, 20f);
    }
}
