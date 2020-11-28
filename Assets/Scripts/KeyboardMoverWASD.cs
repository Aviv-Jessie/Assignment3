using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyboardMoverWASD : MonoBehaviour
{
    [Tooltip("Speed of movement, in meters per second")]
    [SerializeField] float Speed = 4f;

    protected ForceMode2D forceMode = ForceMode2D.Force;
    private Rigidbody2D rb;

    void Update(){
        float horizontalWASD = Input.GetAxis("HorizontalWASD"); // +1 if right arrow is pushed, -1 if left arrow is pushed, 0 otherwise
        float verticalWASD = Input.GetAxis("VerticalWASD");     // +1 if up arrow is pushed, -1 if down arrow is pushed, 0 otherwise

        // we need to make here RigidBody that changes the Velocity of 
        rb = GetComponent<Rigidbody2D>();
        Vector3 movementVector = new Vector3(horizontalWASD, verticalWASD, 0);
        rb.AddForce(movementVector, forceMode);
    }

}
