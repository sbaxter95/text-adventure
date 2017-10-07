using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextManager : MonoBehaviour {

	public Text text;
	public InputField inputField;

	private enum States {corridor_0, door};
	private States myState;

	void Start () {
		myState = States.corridor_0;
	}

	void Update () {
		if (myState == States.corridor_0) {
			corridor_0 ();
		} else if (myState == States.door) {
			door ();
		}
	}

	void corridor_0 () {
		text.text = "You are a crew member on board the SS Ruby. The ship computer, SINATRA has malfunctioned, and has turned against the crew. " +
			"It is your job to make your way through the ship to SINATRA's brain and shut it down. There is a door to the north" + '\n';
		if (inputField.text == "GO NORTH") {
			myState = States.door;
		}
	}

	void door () {
		text.text = "The door is locked";
	}
}
