using UnityEngine;
using System.Collections;

public class MoveTest : MonoBehaviour {
	
	public float speed = 0.5f;
	
	// Update is called once per frame
	void Update () {
		if ( Input.GetKey (KeyCode.W) ) {
			transform.position += new Vector3( 0f, 0f, 1f ) * speed;
			// transform.position += Vector3.forward;
			// transform.Translate( 0f, 0f, 1f );
		}

		if (Input.GetKey (KeyCode.S) ) {
			transform.position += new Vector3( 0f, 0f, -speed );
		}

		if (Input.GetKey (KeyCode.A) ) {
			transform.position += new Vector3( -speed, 0f, 0f );
		}

		if (Input.GetKey (KeyCode.D) ) {
			transform.position += new Vector3( speed, 0f, 0f );
		}

	}
}
