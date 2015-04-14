using UnityEngine;
using System.Collections;

public class PhysicsMove : MonoBehaviour {

	Rigidbody rBody; // cache a reference to the rigidbody we want to access

	// tuning variables
	public float moveSpeed = 10f;
	public float turnRate = 100f;

	public float health = 500f; // I lose health in PowerBoost.OnTriggerEnter()
	
	void Start () {
		// which rigidbody we want to talk to
		rBody = GetComponent<Rigidbody>();

	}
	
	// FixedUpdate is called once per physics frame
	// to see how fast it runs, go to Unity >> Edit Project Settings > Time > Fixed Timestep
	void FixedUpdate () {
		// add positional velocity based on W/S or UpArrow/DownArrow
		rBody.AddForce( transform.forward * Input.GetAxis ( "Vertical" ) * moveSpeed );

		// add angular velocity based on A/D or LeftArrow/RightArrow
		rBody.AddTorque( new Vector3(0f, turnRate, 0f) * Input.GetAxis ( "Horizontal") );

		// if player presses SPACE then 
		if (Input.GetKeyDown (KeyCode.Space) ) {
			rBody.velocity = new Vector3(0f, 0f, 0f); // stops moving
			rBody.angularVelocity = new Vector3(0f, 0f, 0f); // stops turning
		}
	}
}



