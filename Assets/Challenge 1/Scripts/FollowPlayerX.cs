using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayerX : MonoBehaviour
{
    public GameObject plane;
    private Vector3 cameraOffset;

    private Vector3 cameraFollow = new Vector3(30, 0, 10);
    private Vector3 cameraFollowRotation = new Vector3(0, -90, 0);

    private Vector3 cameraFront = new Vector3(0, 3.3f, 5.5f);
    private Vector3 cameraFrontRotation = new Vector3(25, -180, 0);


    // Start is called before the first frame update
    void Start()
    {
        cameraOffset = cameraFollow;
        transform.rotation = Quaternion.Euler(cameraFollowRotation);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.F1))
        {
            cameraOffset = cameraFollow;
            transform.rotation = Quaternion.Euler(cameraFollowRotation);
        }
        else if (Input.GetKey(KeyCode.F2))
        {
            cameraOffset = cameraFront;
            transform.rotation = Quaternion.Euler(cameraFrontRotation);
        }

        transform.position = plane.transform.position + cameraOffset;
    }
}
