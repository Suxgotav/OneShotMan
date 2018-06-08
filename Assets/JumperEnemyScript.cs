using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumperEnemyScript : MonoBehaviour {

	// Use this for initialization
	bool isGrounded;
	void Start () {
		isGrounded=false;
	}
	
	// Update is called once per frame
	void Update () {
		if(isGrounded){
			Jump();
		}	
	}

	void Jump(){
		GetComponent<Rigidbody2D>().velocity = new Vector2 (-0.5f,6);
	}

	void OnTriggerEnter2D(Collider2D other){
			if (other.tag.Equals("Ground") || other.tag.Equals("MovingPlataform")){
				isGrounded=true;
			}			
	}

	void OnTriggerExit2D(Collider2D other){
		isGrounded=false;
	}
}
