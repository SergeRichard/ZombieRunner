using UnityEngine;
using System.Collections;

public class Helicopter : MonoBehaviour {

	public AudioClip CallSound;

	private bool called = false;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetButtonDown ("CallHeli") && !called) {
			called = true;
			//Play sound

		} 
	}
}
