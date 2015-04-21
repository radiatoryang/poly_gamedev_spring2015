using UnityEngine;
using System.Collections;

public class ScreenShake : MonoBehaviour {

	// public static vars = accessible by ANYWHERE IN CODEBASE, and they PERSIST THROUGH LEVEL CHANGES
	public static float shakeStrength = 0f;

	Vector3 whereWeStarted;
	Vector3 randomOffset;

	// Use this for initialization
	void Start () {
		whereWeStarted = Camera.main.transform.position;
	}


	// Update is called once per frame
	void Update () {
		randomOffset = Random.insideUnitSphere;

		Camera.main.transform.position = Vector3.Lerp ( 
		                                               Camera.main.transform.position, 
		                                               whereWeStarted + randomOffset * shakeStrength, 
		                                               Time.deltaTime * 10f 
		                                              );

		// gradually reduce to zero
		shakeStrength = Mathf.Lerp ( shakeStrength, 0f, Time.deltaTime * 10f );

		// DEBUG
		if ( Application.isEditor && Input.GetKeyDown(KeyCode.Space) ) {
			shakeStrength = 5f;
		}
	}
}
