using UnityEngine;
using System.Collections;

public class Scorekeeper : MonoBehaviour {

	// easiest way to keep score between scene changes
	// is to use a STATIC variable

	public static int player1Score, player2Score;

	// Use this for initialization
	void Start () {
		if ( PlayerPrefs.HasKey ( "p1Score" ) ) {
			player1Score = PlayerPrefs.GetInt ( "p1Score" );
		}
	}
	
	// Update is called once per frame
	void Update () {


		if (Input.GetKeyDown (KeyCode.Space) ) {
			player1Score++;
			player2Score++;
			Debug.Log ( player1Score );
		}

		if (Input.GetKeyDown (KeyCode.P) ) {
			Debug.Log ("saved to player prefs");
			PlayerPrefs.SetInt ( "p1Score", player1Score );
			PlayerPrefs.SetInt ( "p2Score", player2Score );
			PlayerPrefs.Save ();
		}


	}
}
