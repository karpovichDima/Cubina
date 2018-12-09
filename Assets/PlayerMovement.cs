using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody rb;
    public float forwardForce = 500f;
    public float sidewayForce = 500f;
    private Vector3 acceleration;

	void FixedUpdate () {
	    acceleration = Input.acceleration;
        rb.AddForce(0, 0, forwardForce * Time.deltaTime);
        rb.AddForce(1000 * acceleration.x * Time.deltaTime, 0, 0 );
	    
    }
}
