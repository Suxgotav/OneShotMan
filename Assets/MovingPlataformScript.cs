using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingPlataformScript : MonoBehaviour {
	
	public bool vertical;
	public float xy;

	bool onGround;
	// Use this for initialization
	void Start () {
		onGround=false;
	}
	
	// Update is called once per frame
	void Update () {
		if(vertical && onGround){
			Vector2 direction = new Vector2(0,xy);
			GetComponent<Rigidbody2D>().velocity  = direction;
		}else if(onGround){
			Vector2 direction = new Vector2(xy,0);
			GetComponent<Rigidbody2D>().velocity  = direction;
		}
	}

	void OnTriggerEnter2D(Collider2D other){
		if(other.tag.Equals("Player")){
			onGround=true;
		}
		if(other.tag.Equals("Ground")){
			xy = xy *-1;
		}
	}
}
