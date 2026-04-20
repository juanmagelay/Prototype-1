using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    // Variable named "player" of type GameObject, getting a reference from Unity
    public GameObject player;
    // Variable named "offset" to store the permanent distance between the player and the camera
    private Vector3 offset = new Vector3(0, 6, -9);
    void Start()
    {
        
    }

    // Update is called once per frame
    void LateUpdate()
    {
        // Assign the position of the player to the camera.
        transform.position = player.transform.position + offset;
    }
}
