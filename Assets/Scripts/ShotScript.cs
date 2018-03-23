using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShotScript : MonoBehaviour {
void Start () {	
		
	}
	
	// Update is called once per frame
	void Update () {
		if(transform.position.x > GameObject.FindGameObjectWithTag("Player").transform.position.x + 15){
			GameObject.FindWithTag("Player").SendMessage("CallCanShoot");
			Destroy(this.gameObject);
		}
		if(transform.position.y > GameObject.FindGameObjectWithTag("Player").transform.position.y + 15){
			GameObject.FindWithTag("Player").SendMessage("CallCanShoot");
			Destroy(this.gameObject);
		}
		if(transform.position.x < GameObject.FindGameObjectWithTag("Player").transform.position.x - 15){
			GameObject.FindWithTag("Player").SendMessage("CallCanShoot");
			Destroy(this.gameObject);
		}
	}

	void OnTriggerEnter2D(){
		GameObject.FindWithTag("Player").SendMessage("CallCanShoot");
		Destroy(this.gameObject);
	}
}
