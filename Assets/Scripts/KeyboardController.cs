using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/**
 * This component moves its object when the player clicks the arrow keys.
 */
[RequireComponent(typeof(ModeSwitcher))]
[RequireComponent(typeof(Rigidbody2D))]
public class KeyboardController: MonoBehaviour {

    [Tooltip("defence key to press, dafault=L")]
    [SerializeField] protected KeyCode keyToDefender = KeyCode.L;
    [Tooltip("defence key to thrown, dafault=L")]
    [SerializeField] protected KeyCode keyToThrown = KeyCode.Space;
    [SerializeField] protected float speed = 0.7f;

    [SerializeField] protected ForceMode2D forceMode = ForceMode2D.Impulse;
    private Rigidbody2D rb;
    private ModeSwitcher modeNow;


    private void Start()
    {
        modeNow = GetComponent<ModeSwitcher>();
    }



    void Update() {

        
        //float horizontal = Input.GetAxis("Horizontal"); // +1 if right arrow is pushed, -1 if left arrow is pushed, 0 otherwise
        //float vertical = Input.GetAxis("Vertical");     // +1 if up arrow is pushed, -1 if down arrow is pushed, 0 otherwise                

        float horizontal = 0;
        float vertical = 0;

        if (Input.GetKey(KeyCode.UpArrow)){
            vertical = 1;
        }
        if (Input.GetKey(KeyCode.DownArrow)){
            vertical = -1;
        }
        if (Input.GetKey(KeyCode.LeftArrow)){
            horizontal = -1;
        }
        if (Input.GetKey(KeyCode.RightArrow)){
            horizontal = 1;
        }

        // we need to make here RigidBody that changes the Velocity of 
        rb = GetComponent<Rigidbody2D>();
        //forceMode = Impulse. speed = 0.7f. and linear drag =10 in rigidbody2D make controler to be comfortable.
        Vector3 movementVector = new Vector3(horizontal, vertical, 0)*speed;
        rb.AddForce(movementVector, forceMode);

        //if we do this way. the player ignore the limit on the field.
        //Vector3 movementVector = new Vector3(horizontal, vertical, 0) * 5 * Time.deltaTime; 
        //transform.position += movementVector;

        //defender and thrown
        if (Input.GetKeyDown(keyToDefender))
        {
            modeNow.SwitchToDefenderPlayer();
        }
        if (Input.GetKeyDown(keyToThrown))
        {
            modeNow.SwitchToWithoutBallPlayer();
        }
     }
}