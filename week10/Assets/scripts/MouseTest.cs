using UnityEngine;
using System.Collections;

public class MouseTest : MonoBehaviour {

	public float speed = 5f;
	public float turnSpeed = 5f;

	// Update is called once per frame
	void Update () {

		// FRAMERATE-DEPENDENT BEHAVIOR = faster computers result in different behavior
		// to make something FRAMERATE-INDEPENDENT, multiply Time.deltaTime

		// Time.deltaTime is the fraction of a second between frames

		// GetKey (holding) vs. GetKeyDown (tap)
		if ( Input.GetKey (KeyCode.UpArrow) || Input.GetKey (KeyCode.W) ) {
			transform.position += transform.forward * speed * Time.deltaTime;
		}

//		if ( Input.GetAxis ("Mouse X") > 0.5f ) {
//			transform.Rotate ( 0f, 1f, 0f );
//		} else if ( Input.GetAxis ("Mouse X") < -0.5f ) {
//			transform.Rotate ( 0f, -1f, 0f );
//		}

		transform.Rotate ( 0f, Input.GetAxis ("Mouse X") * turnSpeed * Time.deltaTime, 0f );

	}
}
