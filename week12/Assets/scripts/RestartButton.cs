using UnityEngine;
using System.Collections;

public class RestartButton : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
		// to make a restart button, one easy way to do it
		// is to just reload your current level
		if ( Input.GetKey (KeyCode.LeftControl) && Input.GetKeyDown (KeyCode.F5) ) {
			Application.LoadLevel ( Application.loadedLevel );
		}
	}
}
