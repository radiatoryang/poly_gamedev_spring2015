using UnityEngine;
using System.Collections;

using UnityEngine.UI;// you need this line to use Text

public class TextAdventure : MonoBehaviour
{

	Text textComponent; // by default, private

	string currentRoom = "2 Metrotech Lobby";

	// Use this for initialization
	void Start ()
	{
		textComponent = GetComponent<Text> ();
	}
	
	// Update is called once per frame
	void Update ()
	{
//		textComponent.text += "Meow ";

		if (currentRoom == "2 Metrotech Lobby") {
			textComponent.text = "You are in the lobby. It is beautiful.\nPress [E] to enter the elevators.";

			if (Input.GetKeyDown (KeyCode.E)) {
				currentRoom = "Room 817";
			}
		} else if (currentRoom == "Room 817") {
			textComponent.text = "You made it to class. You're late, by the way. You get an F.";
		}

	}
}



