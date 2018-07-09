using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HighJumpEnemy : MonoBehaviour {

	GameObject player; 
	private int jumpTimes;

	bool okLeft, okRight;

	bool grounded;

	// Use this for initialization
	void Start () {
		player = GameObject.FindGameObjectWithTag("Player") ;	
		InvokeRepeating("Jump",0.0f,2.0f);
	}
	
	// Update is called once per frame
	void Update () {
		if (player.transform.position.x >= transform.position.x -10 && player.transform.position.x < transform.position.x){
				okLeft=true;
				okRight=false;
				//Invoke("Jump",0.0f);
		}
		else if (player.transform.position.x >= transform.position.x && player.transform.position.x < transform.position.x + 15){
				okRight=true;
				okLeft=false;
			}
	}

	void Jump(){
		if(okLeft && grounded){
			okRight=false;
			this.GetComponent<Rigidbody2D>().AddForce(new Vector2(-3,9),ForceMode2D.Impulse);
		}
		if(okRight && grounded){
			okLeft=false;
			this.GetComponent<Rigidbody2D>().AddForce(new Vector2(3,9),ForceMode2D.Impulse);
		}
	}

	void OnTriggerEnter2D(Collider2D other){
		if(other.tag.Equals("Ground")){
			grounded=true;
		}
	}

}
