using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemiesSpawner : MonoBehaviour {

	public GameObject enemyPrefab;
	public float delai = 0.3f;
	
	// Use this for initialization
	void Start () {
		InvokeRepeating("SpawnEnemy", 0f, delai);
	}
		void SpawnEnemy() {
		Instantiate(enemyPrefab);		
	}
}
