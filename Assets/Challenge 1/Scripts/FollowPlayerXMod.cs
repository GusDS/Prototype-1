﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayerXMod : MonoBehaviour
{
    public GameObject plane;
    private Vector3 offset = new Vector3(0, 3.5f, -7);
    private Vector3 offsetRotation = new Vector3(15, 0, 0);

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = plane.transform.position + offset;
        transform.rotation = Quaternion.Euler(offsetRotation);
    }
}
