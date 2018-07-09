using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShooterEnemyController : MonoBehaviour {

	// Use this for initialization
	public GameObject enemyShot;
	void Start () {
		InvokeRepeating("EnemyShoot",0.0f,3.0f);
	}
	
	// Update is called once per frame
	void Update () {
		
	
	}

	void EnemyShoot(){
		GameObject newShot = Instantiate(enemyShot);
		newShot.transform.position = transform.position - new Vector3(1.0f,0.0f);
	}

	void OnTriggerEnter2D(Collider2D other){
		if(other.tag.Equals("Shot")){
			Destroy(this.gameObject);
		}
	}
}
