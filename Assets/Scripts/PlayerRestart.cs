using UnityEngine;

public class PlayerRestart : MonoBehaviour {

    public Transform _userPosition;

	void Update () {
	    if (_userPosition.position.z >= 150)
	    {
	       _userPosition.SetPositionAndRotation(new Vector3(_userPosition.position.x, _userPosition.position.y,
	           0), _userPosition.rotation);
        } else if (_userPosition.position.y <= 0)
	    {
	       _userPosition.SetPositionAndRotation(new Vector3(_userPosition.position.x, 0.8f,
	            0), _userPosition.rotation);
        }
	}
}
