using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody rb;
    public float forwardForce = 500f;
    public float sidewayForce = 500f;

	void FixedUpdate () {

	    rb.AddForce(0, 0, forwardForce * Time.deltaTime);
        if (Input.GetKey("d"))
	    {
	        rb.AddForce(sidewayForce * Time.deltaTime, 0, 0 );
        }

	    if (Input.GetKey("a"))
	    {
	        rb.AddForce(-sidewayForce * Time.deltaTime, 0, 0);
	    }
    }
}
