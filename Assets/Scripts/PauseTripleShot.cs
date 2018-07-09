using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseTripleShot : MonoBehaviour {


	public GameObject shot;
	
	public float shotDirection;
	
	public int shotState;

	// Use this for initialization
	void Start () {
		shotState=0;
		InvokeRepeating("Shoot",0.0f,4.0f);
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void Shoot(){
		if(shotState.Equals(0)){
			GameObject newShot = Instantiate(shot);	
			newShot.transform.position = transform.position;
			newShot.GetComponent<Rigidbody2D>().velocity = new Vector2(shotDirection,1);
			shotState = 1;
		}
		else if(shotState.Equals(1)){
			GameObject newShot = Instantiate(shot);	
			newShot.transform.position = transform.position;
			newShot.GetComponent<Rigidbody2D>().velocity = new Vector2(shotDirection,0);
			shotState = 2;
		}
		else if(shotState.Equals(2)){
			GameObject newShot = Instantiate(shot);	
			newShot.transform.position = transform.position;
			newShot.GetComponent<Rigidbody2D>().velocity = new Vector2(shotDirection,-1);
			shotState = 0;
		}

	}
}
