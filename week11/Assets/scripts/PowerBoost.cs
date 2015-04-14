using UnityEngine;
using System.Collections;

public class PowerBoost : MonoBehaviour {

	// OnTriggerEnter is a special function that is called automatically upon something
	// entering a trigger collider on the same object
	void OnTriggerEnter ( Collider activator ) {
		Debug.Log ("something entered the trigger!!! omg");
		activator.GetComponent<Rigidbody>().velocity *= 5f; // increase speed by 500%
		Destroy ( this.gameObject ); // self-destruct so this powerup is used-up

		// access a public variable on my own script
		activator.GetComponent<PhysicsMove>().health -= 10f;
	}
}
