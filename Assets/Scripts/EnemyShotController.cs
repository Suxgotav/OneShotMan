using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyShotController : MonoBehaviour {

	// Use this for initialization
	void Start () {
		GetComponent<Rigidbody2D>().velocity = new Vector2(-6,0);	
		if(this.transform.position.x < GameObject.FindGameObjectWithTag("Player").transform.position.x + 5.0f ){
			Destroy(this.gameObject);
		}
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
