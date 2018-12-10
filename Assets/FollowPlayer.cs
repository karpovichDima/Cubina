using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public Transform player;
    public Vector3 offset;

	void Update ()
	{
        // set coordinates for camera equals coordinates of the player
	    transform.position = player.position + offset;
	}
}
