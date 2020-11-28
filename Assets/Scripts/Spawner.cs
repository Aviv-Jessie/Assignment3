using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
 
    [SerializeField] public Transform positionOfSpawnedObject;
    [SerializeField] public GameObject prefabToSpawn;
    [SerializeField] public Vector3 velocityOfSpawnedObject;
    private ForceMode2D forceMode = ForceMode2D.Impulse;
    private Rigidbody2D rb;

    public void spawnObject() {
        // Step 1: spawn the new object.        
        Quaternion rotationOfSpawnedObject = Quaternion.identity;  // no rotation.
        GameObject newObject = Instantiate(prefabToSpawn, positionOfSpawnedObject.position, rotationOfSpawnedObject);

        // we need to make here RigidBody that changes the Velocity of 
        rb = newObject.GetComponent<Rigidbody2D>();
        rb.AddForce(velocityOfSpawnedObject, forceMode);

    }
}
