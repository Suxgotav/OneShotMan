using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SurpriseEnemyScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
		InvokeRepeating("Jump",0.0f,3.0f);
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void Jump(){
		this.GetComponent<Rigidbody2D>().AddForce(new Vector3(0,10));
	}
}
