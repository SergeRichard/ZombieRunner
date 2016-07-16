using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour {

	public Transform PlayerSpawnPoints;
	public bool ReSpawn = false;

	private bool lastToggle = false;
	private Transform[] SpawnPoints;

	// Use this for initialization
	void Start () {
		SpawnPoints = PlayerSpawnPoints.GetComponentsInChildren<Transform> ();
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
}
