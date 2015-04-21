using UnityEngine;
using System.Collections;

public class SmoothFollow : MonoBehaviour {

	public Transform followThis; // assign in Inspector

	bool didIShakeAlready;

	// Update is called once per frame
	void Update () {
		// instantly override current position
	//	transform.position = followThis.position;

		transform.position = Vector3.Lerp ( transform.position, followThis.position, Time.deltaTime * 10f );

		if ( Vector3.Distance ( transform.position, followThis.position ) < 1f ) {
			if (didIShakeAlready == false) {
				ScreenShake.shakeStrength = 5f;
				didIShakeAlready = true;
			}
		} else {
			didIShakeAlready = false;
		}

	}
}
