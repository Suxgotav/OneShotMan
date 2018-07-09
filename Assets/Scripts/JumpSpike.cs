using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpSpike : MonoBehaviour {

	// Use this for initialization
	void Start () {
		InvokeRepeating("Impulse",0.0f,2.0f);
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void Impulse(){
		GetComponent<Rigidbody2D>().AddForce(new Vector2(0,8),ForceMode2D.Impulse);
	}
}
