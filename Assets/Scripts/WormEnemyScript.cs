using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WormEnemyScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
		InvokeRepeating("Jump",0.0f,0.0f);
	}
	
	// Update is called once per frame
	void Update () {

	}

	void Jump(){
		this.GetComponent<Rigidbody2D>().AddForce(new Vector2(0,40), ForceMode2D.Impulse);		
	}

}
