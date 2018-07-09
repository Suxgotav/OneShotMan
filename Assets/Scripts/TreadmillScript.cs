using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TreadmillScript : MonoBehaviour {

	// Use this for initialization

	public float speed;

	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerStay2D(Collider2D other){
		if(other.tag.Equals("Player")){
			other.transform.Translate(Vector2.left * speed * Time.deltaTime);
		}
	}
}
