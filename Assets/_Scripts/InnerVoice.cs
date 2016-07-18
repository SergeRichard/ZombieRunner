using UnityEngine;
using System.Collections;

public class InnerVoice : MonoBehaviour {

	public AudioClip WhatHappened;
	public AudioClip GoodLandingArea;

	private AudioSource audioSource;

	// Use this for initialization
	void Start () {
		audioSource = GetComponent<AudioSource> ();
		audioSource.clip = WhatHappened;
		audioSource.Play ();
	}
	
	void OnFindClearArea() {
		print (name + " OnFindClearArea");
		audioSource.clip = GoodLandingArea;
		audioSource.Play ();

		Invoke ("CallHeli", GoodLandingArea.length + 1f);
	}
	void CallHeli() {
		SendMessageUpwards ("OnMakeInitialHeliCall");

	}
}
