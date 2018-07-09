using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TripleShootEnemy : MonoBehaviour {

	
	
	// Use this for initialization
	public GameObject enemyShot;
	void Start () {
		InvokeRepeating("EnemyShoot",0.0f,2.0f);
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void EnemyShoot(){
		GameObject newShot = Instantiate(enemyShot);
		newShot.transform.position = transform.position - new Vector3(0.5f,0.0f);
		newShot.GetComponent<Rigidbody2D>().velocity = new Vector3(-4,1);
		GameObject newShot2 = Instantiate(enemyShot);
		newShot2.transform.position = transform.position - new Vector3(0.5f,0.0f);
		newShot2.GetComponent<Rigidbody2D>().velocity = new Vector3(-4,-1);
		GameObject newShot3 = Instantiate(enemyShot);
		newShot3.transform.position = transform.position - new Vector3(0.5f,0.0f);
		newShot3.GetComponent<Rigidbody2D>().velocity = new Vector3(-4,0);
	}

	void OnTriggerEnter2D(Collider2D other){
		if(other.tag.Equals("Enemy")){
			Physics2D.IgnoreCollision(this.GetComponent<Collider2D>(),other);
		}

		if(other.tag.Equals("Shot")){
			Destroy(this.gameObject);
		}
	}
}
