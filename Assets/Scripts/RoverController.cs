using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoverController : MonoBehaviour
{
    public float speed = 15.5f;
    public float turnSpeed = 40;
    private float horizontalInput;
    private float forwardInput;

    void Start()
    {

    }

    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        forwardInput = Input.GetAxis("Vertical");
        // transform.Translate(Vector3.forward * Time.deltaTime * speed * forwardInput);
        // transform.Rotate(Vector3.up, turnSpeed * horizontalInput * Time.deltaTime);
        // No movemos/giramos el personaje, sino que aplicamos rotación al planeta (mov. inverso al del player)
        transform.Rotate(Vector3.right, -speed * forwardInput * Time.deltaTime);
        transform.Rotate(Vector3.up, -turnSpeed * horizontalInput * Time.deltaTime);
    }
}
