using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// this light source oscillates and reports its intensity levels to our local analytics library
/// it is part of a pupil dilation experiment/test  
/// </summary>
/// 
[RequireComponent(typeof(Light))]
public class OscillatingLightSource : MonoBehaviour
{

    private Light _lt;
    void Start()
    {
        _lt = GetComponent<Light>();
        FixedUpdate();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        _lt.intensity = Mathf.PingPong(Time.time, 8);
        print(_lt.intensity);
    }
}
