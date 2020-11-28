using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class AutoMover1 : MonoBehaviour
{
    [SerializeField] public float speed = 20f;
    private ForceMode2D forceMode = ForceMode2D.Force;
    private Rigidbody2D rb;

    // Start is called before the first frame update
    void Start()
    {
          rb = GetComponent<Rigidbody2D>();                    
    }

    // Update is called once per frame
    void Update()
    {
        var rand = new System.Random();
        float Horizontal = (float)(rand.NextDouble() * 2 - 1);//random between -1 to 1.
        float Vertical = (float)(rand.NextDouble() * 2 - 1);//random between -1 to 1.
        Vector3 movementVector = new Vector3(Horizontal*speed, Vertical*speed, 0);
        rb.AddForce(movementVector, forceMode);

    }
}
