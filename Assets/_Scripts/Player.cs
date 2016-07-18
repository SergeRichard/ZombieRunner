using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour {

	public Transform PlayerSpawnPoints;

	private bool ReSpawn = false;
	private bool lastRespawnToggle = false;
	private Transform[] SpawnPoints;

	// Use this for initialization
	void Start () {
		SpawnPoints = PlayerSpawnPoints.GetComponentsInChildren<Transform> ();

	}
	
	// Update is called once per frame
	void Update () {
		if (lastRespawnToggle != ReSpawn) {
			Respawn ();
			ReSpawn = false;
		} else {
			lastRespawnToggle = ReSpawn;
		}
	}
	private void Respawn() {
		int i = Random.Range (1, SpawnPoints.Length);
		transform.position = SpawnPoints [i].transform.position;

	}

	void OnFindClearArea() {
		Invoke ("DropFlare", 3f);
	}
	void DropFlare() {

	}
}
