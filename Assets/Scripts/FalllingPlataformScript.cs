using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FalllingPlataformScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

	}

	void OnTriggerEnter2D(Collider2D other){
		if(other.tag.Equals("Player")){
			Invoke("FallDown",0.05f);
		}
	}

	void FallDown(){
		GetComponent<Rigidbody2D>().isKinematic = false;
	}
}
