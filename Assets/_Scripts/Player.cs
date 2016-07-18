using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour {
	public Helicopter Helicopter;
	public Transform PlayerSpawnPoints;
	public AudioClip WhatHappened;

	private AudioSource innerVoice;
	private bool ReSpawn = false;
	private bool lastToggle = false;
	private Transform[] SpawnPoints;

	// Use this for initialization
	void Start () {
		SpawnPoints = PlayerSpawnPoints.GetComponentsInChildren<Transform> ();

		AudioSource[] audioSources = GetComponents<AudioSource> ();
		foreach (AudioSource audioSource in audioSources) {
			if (audioSource.priority == 1) {
				innerVoice = audioSource;
			}
		}

		innerVoice.clip = WhatHappened;
		innerVoice.Play ();
	}
	
	// Update is called once per frame
	void Update () {
		if (lastToggle != ReSpawn) {
			Respawn ();
			ReSpawn = false;
		} else {
			lastToggle = ReSpawn;
		}
	}
	private void Respawn() {
		int i = Random.Range (1, SpawnPoints.Length);
		transform.position = SpawnPoints [i].transform.position;

	}

	void OnFindClearArea() {
		Debug.Log ("Found clear area in player");
		Helicopter.Call ();
	}
}
