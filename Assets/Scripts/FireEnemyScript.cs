using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireEnemyScript : MonoBehaviour {

	// Use this for initialization
	
	public float xPosition;
	public float xOtherPosition;
	void Start () {
		InvokeRepeating("Flip",3.0f,3.0f);
		xPosition = 1;
		xOtherPosition = 3;
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void Flip(){
		xPosition = xPosition*-1;
		this.gameObject.transform.localScale = new Vector3((xPosition),1,1);
		this.gameObject.transform.position = this.gameObject.transform.position + new Vector3(xOtherPosition,0,0);
		xOtherPosition = xOtherPosition *-1;
	}

	void OnCollisionEnter2D(Collider2D other){
		if(other.tag.Equals("Shot")){
			Destroy(this.gameObject);
		}
	}

	void OnTriggerEnter2D(Collider2D other){
		if(other.tag.Equals("Shot")){
			Destroy(this.gameObject);
		}
	}
}
