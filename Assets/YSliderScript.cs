using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class YSliderScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerEnter2D(Collider2D other){
		if(other.tag.Equals("Player")){
			GameObject.FindGameObjectWithTag("MainCamera").SendMessage("CanYSlide");
		}
	}
}
