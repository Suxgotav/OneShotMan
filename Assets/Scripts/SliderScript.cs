using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SliderScript : MonoBehaviour {

	public bool canCant;
	// Use this for initialization
	void Start () {
				
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerEnter2D(Collider2D other){
		if(other.tag.Equals("Player")){
			if(canCant){
				GameObject.FindGameObjectWithTag("MainCamera").SendMessage("CanSlide");
			}
			else if (!canCant){
				GameObject.FindGameObjectWithTag("MainCamera").SendMessage("CantSlide");
			}
		}
	}
}
