using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy2Controller : MonoBehaviour {

	public GameObject enemyShot;
	// Use this for initialization
	void Start () {
		GetComponent<Rigidbody2D>().velocity = new Vector2(-1,0);
		InvokeRepeating("EnemyShoot",1.0f,3.0f);
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void EnemyShoot(){
		GameObject newShot = Instantiate(enemyShot);
		newShot.transform.position = transform.position - new Vector3(2.0f,0.5f);
	}

	void OnTriggerEnter2D(Collider2D other){
		if(other.tag.Equals("Shot")){
			Destroy(this.gameObject);
		}
	}
}
