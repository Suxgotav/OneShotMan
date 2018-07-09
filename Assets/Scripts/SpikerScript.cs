using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpikerScript : MonoBehaviour {


	public bool vertical;
	public float xy;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if(vertical){
			Vector2 direction = new Vector2(0,xy);
			GetComponent<Rigidbody2D>().velocity  = direction;
		}else{
			Vector2 direction = new Vector2(xy,0);
			GetComponent<Rigidbody2D>().velocity  = direction;
		}
	}

	void MoveUp(){
		//this.GetComponent<Rigidbody2D>().AddForce(new Vector2(x,y), ForceMode2D.Impulse);
		//this.GetComponent<Rigidbody2D>().AddForce(new Vector2(x,y));
	}

	void OnTriggerEnter2D(Collider2D other){
		if(other.tag.Equals("MovingPlataform")){
			Physics2D.IgnoreCollision(other.GetComponent<Collider2D>(),this.GetComponent<Collider2D>());
		}
		if(other.tag.Equals("Ground"))
		xy = xy *-1;
	}

	
}
