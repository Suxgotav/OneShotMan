using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LadderScript : MonoBehaviour {


	public GameObject thePlayer;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerEnter2D(Collider2D other){
		if(other.tag.Equals("Player")){
			thePlayer.SendMessage("OnLadder");
		}
	}

	void OnTriggerExit2D(Collider2D other){
		if(other.tag.Equals("Player")){
			thePlayer.SendMessage("OffLadder");
		}
	}
}
