using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // Private variables
    private float horizontalInput;
    private float forwardInput;
    private float speed = 15.0f;
    private float turnSpeed = 30.0f;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Get the player's input
        horizontalInput = Input.GetAxis("Horizontal");
        forwardInput = Input.GetAxis("Vertical");

        // Movement of the vehicle forward with a speed in m/s, because deltaTime is equal to one second
        transform.Translate(Vector3.forward * Time.deltaTime * speed * forwardInput);
        // Rotation of the vehicle with a turn speed in degrees per second
        transform.Rotate(Vector3.up, Time.deltaTime * turnSpeed * horizontalInput); // Vector3.up is the y-axis, so the vehicle will rotate around the y-axis when the player presses the left or right arrow keys.
    }
}
