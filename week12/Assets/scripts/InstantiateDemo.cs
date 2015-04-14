using UnityEngine;
using System.Collections;

using System.Collections.Generic; // YOU NEED THIS LINE HERE IN ORDER TO USE LISTS

public class InstantiateDemo : MonoBehaviour {

	public Transform originalObject;

	public List<Transform> listOfClones = new List<Transform>();

	// Use this for initialization
	void Start () {

		// make 100 pikachu clones
		int counter = 0;
		while ( counter < 100 ) {
			Transform newClone = (Transform)Instantiate ( originalObject, Random.insideUnitSphere * 10f, Random.rotation );
			listOfClones.Add ( newClone ); // remember this clone in our list
			newClone.name = "Pikachu II";
			counter++;
		}
	}
	
	// Update is called once per frame
	void Update () {
	
		// iterate through the list of clones we instantiated
		foreach ( Transform clone in listOfClones ) {
			clone.Rotate ( 0f, 90f * Time.deltaTime, 0f );
		}

		foreach ( Transform clone in listOfClones ) {
			clone.GetComponent<Pikachu>().pulsing = Input.GetKey (KeyCode.Space);
		}

	}
}





