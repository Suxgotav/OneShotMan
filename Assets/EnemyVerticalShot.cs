using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyVerticalShot : MonoBehaviour {

	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnCollisionEnter2D(Collider2D other){
		if(other.tag.Equals("Ground") || other.tag.Equals("Enemy"))
		Destroy(this.gameObject);
	}

	void OnTriggerEnter2D(Collider2D other){
		if(other.tag.Equals("Ground") || other.tag.Equals("Enemy") || other.Equals("MovingPlataform"))
		Destroy(this.gameObject);
	}
}
