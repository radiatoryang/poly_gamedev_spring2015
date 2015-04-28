using UnityEngine;
using System.Collections;

public class SoundDemo : MonoBehaviour {

	bool shouldIPlayASound;

	public AudioClip screamSound1;

	// Update is called once per frame
	void Update () {
		// "one shot"
		if (Input.GetKeyDown (KeyCode.Space)) {
			AudioSource.PlayClipAtPoint( screamSound1, transform.position, 1f );
			Invoke ( "StartGame", 3f );
		}

		// loop a sound after a certain event
		if (shouldIPlayASound && GetComponent<AudioSource>().isPlaying == false) {
			GetComponent<AudioSource>().Play ();
		}
	}

	void StartGame () {
		Application.LoadLevel ( "mainGameScene" );
	}
}
