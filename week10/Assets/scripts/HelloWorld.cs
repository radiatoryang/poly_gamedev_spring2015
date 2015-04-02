using UnityEngine;
using System.Collections;

public class HelloWorld : MonoBehaviour {

	// Use this for initialization
	void Start () {
		Debug.Log ( "Hello World" );
	}
	
	// Update is called once per frame
	void Update () {
		Debug.Log ( "The time is: " + Time.time.ToString () );
	}
}
