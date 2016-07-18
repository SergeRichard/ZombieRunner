using UnityEngine;
using System.Collections;

public class RadioSystem : MonoBehaviour {

	public AudioClip InitialHeliCall;
	public AudioClip InitialCallReply;

	private AudioSource audioSource;

	// Use this for initialization
	void Start () {
		audioSource = GetComponent<AudioSource> ();
	}
	
	void OnMakeInitialHeliCall() {
		print (name + " OnMakeInitialHeliCall");
		audioSource.clip = InitialHeliCall;
		audioSource.Play ();
		Invoke ("InitialReply", InitialHeliCall.length + 1f);
	}

	void InitialReply() {
		audioSource.clip = InitialCallReply;
		audioSource.Play ();
		BroadcastMessage ("OnDispatchHelicopter");
	}
}
