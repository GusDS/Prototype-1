using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightBlink : MonoBehaviour
{
    public float frequency = 1;
    private float blinkTime;
    void Start()
    {
        blinkTime = frequency;
    }

    void Update()
    {
        blinkTime -= Time.deltaTime;
        if (blinkTime <= 0)
        {
            this.GetComponent<Light>().enabled = !this.GetComponent<Light>().enabled;
            blinkTime = frequency;
        }
    }
}
