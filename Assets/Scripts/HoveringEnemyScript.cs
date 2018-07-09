using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HoveringEnemyScript : MonoBehaviour {

	public GameObject shot;

	// Use this for initialization
	void Start () {
		InvokeRepeating("Left",0.0f,0.5f);
		InvokeRepeating("Right",0.0f,0.6f);
		InvokeRepeating("Shot",0.0f,1.0f);
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void Left(){
		GetComponent<Rigidbody2D>().velocity = new Vector2(-2,0);
	}

	void Right(){
		this.GetComponent<Rigidbody2D>().velocity = new Vector2 (2,0);
	}

	void Shot(){
		GameObject newShot = Instantiate(shot);
		newShot.transform.position = transform.position - new Vector3(0.0f,1.0f);
	}

	void OnCollisionEnter2D(Collider2D other){
		if(other.tag.Equals("Enemy")){
			Physics2D.IgnoreCollision(GetComponent<Collider2D>(),other);
		}
	}

	void OnTriggerEnter2D(Collider2D other){
		if(other.tag.Equals("Enemy")){
			Physics2D.IgnoreCollision(GetComponent<Collider2D>(),other);
		}
	}
}
