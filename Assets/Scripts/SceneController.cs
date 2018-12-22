using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneController : MonoBehaviour {
	// Serialize field to store the prefab
	[SerializeField] private GameObject enemyPrefab;
	// Store a reference to the instance of the enemyPrefab prefab
	private GameObject _enemy;

	// Update is called once per frame
	void Update () {
		
		// If instance has been destroyed instiantiate a new one
		// ** note: enemy is not actually destroyed, just dereferenced in the scene graph
		if(_enemy == null) {
			float angle = Random.Range(0, 360);

			_enemy = Instantiate(enemyPrefab) as GameObject;
			_enemy.transform.position = new Vector3(0, 1, 0);
			_enemy.transform.Rotate(0, angle, 0);
		}

	}
}
