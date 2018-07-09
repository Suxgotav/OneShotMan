using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SmallShotScript : MonoBehaviour {

	float xInitialPosition;
	// Use this for initialization
	void Start () {
		xInitialPosition = this.transform.position.x;
	}
	
	// Update is called once per frame
	void Update () {
		if(this.transform.position.x <= xInitialPosition - 5){
			Destroy(this.gameObject);
		}
	}
}
