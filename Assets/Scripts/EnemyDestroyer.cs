using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyDestroyer : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerEnter2D(Collider2D other){
		if(other.tag.Equals("Enemy")){
			Destroy(other.gameObject);
		}
		if(other.tag.Equals("Player")){
			Physics2D.IgnoreCollision(this.GetComponent<Collider2D>(),other);
		}
	}
}
