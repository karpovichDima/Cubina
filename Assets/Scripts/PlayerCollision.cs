using System;
using System.Threading;
using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    public Transform _userPosition;
    public PlayerMovement _movement;

    void OnCollisionEnter(Collision collisionInfo)
    {
        if (collisionInfo.collider.tag == "Obstacle")
        {
            Handheld.Vibrate();
            _movement.enabled = false;
            FindObjectOfType<GameManager>().EndGame();
        }  
    }
}
