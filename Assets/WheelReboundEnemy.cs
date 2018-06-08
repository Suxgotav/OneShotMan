using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WheelReboundEnemy : MonoBehaviour {

	public float xDirection;

	
	// Use this for initialization
	void Start () {
		this.GetComponent<Rigidbody2D>().AddForce(new Vector3(xDirection,0,0));
	}
	
	// Update is called once per frame
	void Update () {
		this.GetComponent<Rigidbody2D>().AddForce(new Vector3(xDirection,0,0));
	}

	void OnTriggerEnter2D(Collider2D other){
		if(other.tag.Equals("Wall")){
			xDirection = xDirection * -1;
		}
	}
}
