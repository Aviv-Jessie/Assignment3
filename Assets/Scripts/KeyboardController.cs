using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/**
 * This component moves its object when the player clicks the arrow keys.
 */
 [RequireComponent(typeof(ModeSwitcher))]
public class KeyboardController: MonoBehaviour {

    [Tooltip("defence key to press, dafault=L")]
    [SerializeField] protected KeyCode keyToDefender = KeyCode.L;
    [Tooltip("defence key to thrown, dafault=L")]
    [SerializeField] protected KeyCode keyToThrown = KeyCode.Space;
    

    protected ForceMode2D forceMode = ForceMode2D.Force;
    private Rigidbody2D rb;
    private ModeSwitcher modeNow;


    private void Start()
    {
        modeNow = GetComponent<ModeSwitcher>();
    }



    void Update() {
        float horizontal = Input.GetAxis("Horizontal"); // +1 if right arrow is pushed, -1 if left arrow is pushed, 0 otherwise
        float vertical = Input.GetAxis("Vertical");     // +1 if up arrow is pushed, -1 if down arrow is pushed, 0 otherwise
        
        // we need to make here RigidBody that changes the Velocity of 
        rb = GetComponent<Rigidbody2D>();
        Vector3 movementVector = new Vector3(horizontal, vertical, 0);
        rb.AddForce(movementVector, forceMode);

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