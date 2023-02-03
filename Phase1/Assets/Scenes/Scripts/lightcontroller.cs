using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lightcontroller : MonoBehaviour
{
    public Light light1;
    public Light light2;
    void Update()
    {
        if(Input.GetKeyDown("1")){
            light1.enabled = !light1.enabled;
        }
        if(Input.GetKeyDown("2")){
            light2.enabled = !light2.enabled;
        }


    }
}
