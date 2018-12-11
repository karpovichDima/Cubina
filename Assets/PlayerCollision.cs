using System;
using System.Threading;
using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    public Transform _userPosition;
    public Rigidbody _userRigitBody;
    private Thread thread;

    void OnCollisionEnter(Collision collisionInfo)
    {
        if (collisionInfo.collider.tag == "Obstacle")
        {
            Handheld.Vibrate();
            for (int i = 0; i < 6; i++)
            {
                _userPosition.SetPositionAndRotation(new Vector3(_userPosition.position.x, _userPosition.position.y, 
                    _userPosition.position.z - 0.5f), _userPosition.rotation);
            }
        }  
    }
}
