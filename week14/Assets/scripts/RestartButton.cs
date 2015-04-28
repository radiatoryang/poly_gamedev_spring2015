using UnityEngine;
using System.Collections;

public class RestartButton : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		// reload current scene
		if (Input.GetKeyDown (KeyCode.R)) {
			Debug.Log ("I RESTARTED!!!!");
			Application.LoadLevel ( Application.loadedLevel );
		}
	}
}
