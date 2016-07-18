using UnityEngine;
using System.Collections;

public class Helicopter : MonoBehaviour {

	public AudioClip CallSound;

	private AudioSource audioSource;
	private bool called = false;
	private Rigidbody rigidBody;

	// Use this for initialization
	void Start () {
		audioSource = GetComponent<AudioSource> ();
		rigidBody = GetComponent<Rigidbody> ();
	}

	public void Call () {
		if (!called) {
			called = true;
			//Play sound
			audioSource.clip = CallSound;
			audioSource.Play ();
			rigidBody.velocity = new Vector3 (0, 0, 50f);
		}
	}
}
