using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowRover : MonoBehaviour
{
    public GameObject player;
    private Vector3 cameraOffset;

    private Vector3 cameraFollow = new Vector3(0, 260, -8); // -10
    private Vector3 cameraFollowRotation = new Vector3(36, 0, 0);
/*
    private Vector3 cameraFloor = new Vector3(0, 0.36f, 0.77f);
    private Vector3 cameraFloorRotation = new Vector3(0, 0, 0);

    private Vector3 cameraDriver = new Vector3(0, 4, 1.5f);
    private Vector3 cameraDriverRotation = new Vector3(28, 0, 0);

    private Vector3 cameraMovie = new Vector3(2.8f, 2, 0.5f);
    private Vector3 cameraMovieRotation = new Vector3(0, -35, -25);
*/
    void Start()
    {
        cameraOffset = cameraFollow;
        transform.rotation = Quaternion.Euler(cameraFollowRotation);
    }

    void LateUpdate()
    {
/*        if (Input.GetKey(KeyCode.F1)) {
            cameraOffset = cameraFollow;
            transform.rotation = Quaternion.Euler(cameraFollowRotation);
        }
        else if (Input.GetKey(KeyCode.F2))
        {
            cameraOffset = cameraFloor;
            transform.rotation = Quaternion.Euler(cameraFloorRotation);
        }
        else if (Input.GetKey(KeyCode.F3))
        {
            cameraOffset = cameraDriver;
            transform.rotation = Quaternion.Euler(cameraDriverRotation);
        }
        else if (Input.GetKey(KeyCode.F4))
        {
            cameraOffset = cameraMovie;
            transform.rotation = Quaternion.Euler(cameraMovieRotation);
        }
*/
        transform.position = player.transform.position + cameraOffset;
    }
}
