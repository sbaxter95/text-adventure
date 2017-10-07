using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InputManager : MonoBehaviour {

	public Text text;
	public InputField inputField;
	public string playerText;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		playerText = inputField.text;
		if (Input.GetKeyDown(KeyCode.Return)) {
			text.text += (playerText + '\n'); 
			inputField.text = "";
		}
	}
}
