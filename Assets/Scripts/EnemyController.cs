using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour {

	void Start () {
		GetComponent<Rigidbody2D>().velocity = new Vector2(-4,0);
	}
	
	// Update is called once per frame
	void Update () {
		if(transform.position.x < -15){
			Destroy(this.gameObject);
		}
	}

	void OnTriggerEnter2D(Collider2D other){
		if(other.tag.Equals("Shot")){
			Destroy(this.gameObject);
		}
	}
}
