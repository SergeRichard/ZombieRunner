using UnityEngine;
using System.Collections;

public class Helicopter : MonoBehaviour {

	public AudioClip CallSound;

	private AudioSource audioSource;
	private bool called = false;

	// Use this for initialization
	void Start () {
		audioSource = GetComponent<AudioSource> ();
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetButtonDown ("CallHeli") && !called) {
			called = true;
			//Play sound
			audioSource.clip = CallSound;
			audioSource.Play ();
		} 
	}
}
