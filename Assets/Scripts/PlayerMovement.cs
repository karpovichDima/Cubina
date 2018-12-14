using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody rb;
    public float forwardForce = 500f;
    private Vector3 acceleration;

	void FixedUpdate ()
	{
        acceleration = Input.acceleration;
        rb.AddForce(0, 0, forwardForce * Time.deltaTime);
        rb.AddForce(2000 * acceleration.x * Time.deltaTime, 0, 0 );
        Debug.Log("//// acceleration.x = " + acceleration.x + " ////");

        if (rb.position.z > 150)
        {
            FindObjectOfType<GameManager>().EndGame();
        }
        else if (rb.position.y < 0)
        {
            FindObjectOfType<GameManager>().EndGame();
        }
    }

}
