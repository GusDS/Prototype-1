using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightBlinkPlane : MonoBehaviour
{
    public float frequencyOn = 0.5f;
    public float frequencyOff = 2;
    private float blinkTime;
    private bool lightsOn;
    void Start()
    {
        blinkTime = frequencyOn;
        lightsOn = true;
    }

    void Update()
    {
        blinkTime -= Time.deltaTime;
        if (blinkTime <= 0)
        {
            if (lightsOn)
            {
                lightsOn = false;
                blinkTime = frequencyOff;
            } else
            {
                lightsOn = true;
                blinkTime = frequencyOn;
            }
            this.GetComponent<Light>().enabled = !this.GetComponent<Light>().enabled;
        }
    }
}
