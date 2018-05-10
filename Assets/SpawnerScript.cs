using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerScript : MonoBehaviour {

	public GameObject enemy;
	public float x;
	// Use this for initialization
	void Start () {
		InvokeRepeating("Spawn",0.0f,6.0f);
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void Spawn(){
		GameObject newEnemy = Instantiate (enemy);
		newEnemy.transform.position = transform.position + new Vector3 (1.0f,0);
	}
}
