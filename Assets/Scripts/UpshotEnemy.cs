using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpshotEnemy : MonoBehaviour {

	// Use this for initialization
	void Start () {
		this.GetComponent<Rigidbody2D>().velocity = new Vector2 (0,8);	
		Invoke("KillThis",1.5f);
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void KillThis(){
		Destroy(this.gameObject);
	}
}
