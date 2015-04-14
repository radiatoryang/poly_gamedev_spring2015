using UnityEngine;
using System.Collections;

public class Pikachu : MonoBehaviour {

	public bool pulsing = true;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (pulsing) {
			transform.localScale = Vector3.one * Mathf.Sin (Time.time);
		}
	}
}
