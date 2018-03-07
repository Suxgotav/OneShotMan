using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShotScript : MonoBehaviour {
void Start () {	
		
	}
	
	// Update is called once per frame
	void LateUpdate () {
		if(Input.GetKeyDown(KeyCode.RightArrow)){
			GetComponent<Rigidbody2D>().velocity = new Vector2(14,0);
			GetComponent<Rigidbody2D>().isKinematic= false;
		}
		else if(Input.GetKeyDown(KeyCode.UpArrow)){
			GetComponent<Rigidbody2D>().velocity = new Vector2(0,14);
			GetComponent<Rigidbody2D>().isKinematic= false;
		}
		else if(Input.GetKeyDown(KeyCode.LeftArrow)){
			GetComponent<Rigidbody2D>().velocity = new Vector2(-14,0);
			GetComponent<Rigidbody2D>().isKinematic= false;
		}	
		if(transform.position.x > 50 || transform.position.y > 50){
			GameObject.FindWithTag("Player").SendMessage("CallCanShoot");
			Destroy(this.gameObject);	
		}
	}

	void OnTriggerEnter2D(){
		GameObject.FindWithTag("Player").SendMessage("CallCanShoot");
		Destroy(this.gameObject);
	}
}
