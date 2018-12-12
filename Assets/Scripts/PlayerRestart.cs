using UnityEngine;

public class PlayerRestart : MonoBehaviour {

    public Transform _userPosition;

	void Update () {
	    if (_userPosition.position.z >= 60)
	    {
	       _userPosition.SetPositionAndRotation(new Vector3(_userPosition.position.x, _userPosition.position.y,
	           _userPosition.position.z - 60), _userPosition.rotation);
        }
	}
}
