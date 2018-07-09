using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WheelEnemyScript : MonoBehaviour {

	public float xVelocity;

	// Use this for initialization
	void Start () {
		this.GetComponent<Rigidbody2D>().velocity = new Vector3(xVelocity,0);
	}
	
	// Update is called once per frame
	void Update () {
		if(this.gameObject.transform.position.y<=GameObject.FindGameObjectWithTag("Player").transform.position.y - 50){
			Destroy(this.gameObject);
		}		
	}
}
