using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickAxeScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
		Invoke("AutoDestroy",2.0f);
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void AutoDestroy(){
		Destroy(this.gameObject);
		GameObject[] x;
		x = GameObject.FindGameObjectsWithTag("PickAxeEnemy");

		for(var i=0;i<x.Length;i++){
			x[i].SendMessage("PickAxeOK");	
		}
	}
}
