using UnityEngine;
using System.Collections;

public class DiamondSpawner : MonoBehaviour {

	public GameObject[] prefabs;

	// Use this for initialization
	void Start () {

		// infinite coin spawning function, asynchronous
		StartCoroutine(SpawnDiamonds());
	}

	// Update is called once per frame
	void Update () {

	}

	IEnumerator SpawnDiamonds() {
		while (true) {
            // Instantiate a single diamond at a random range
			Instantiate(prefabs[Random.Range(0, prefabs.Length)], new Vector3(26, Random.Range(-10, 10), 10), Quaternion.identity);

			// pause 5-10 seconds until the next diamond spawns
			yield return new WaitForSeconds(Random.Range(5, 10));
		}
	}
}
