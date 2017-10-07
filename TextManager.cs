using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextManager : MonoBehaviour {

	public Text text;

	// Use this for initialization
	void Start () {
		text.text = "Welcome to the game!" + '\n';
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
