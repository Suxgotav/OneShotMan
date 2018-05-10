using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScorpionEnemyController : MonoBehaviour {

	public int speed;
	bool run;
	// Use this for initialization
	void Start () {
		speed=15;
		run=false;
	}
	
	// Update is called once per frame
	void Update () {

		RaycastHit2D groundInfo = Physics2D.Raycast(transform.position,Vector2.left,15f);
		if(groundInfo.collider.CompareTag("Player"))
			run=true;
		if(run)
			transform.Translate(Vector2.left * speed * Time.deltaTime);
		//GetComponent<Rigidbody2D>().velocity = new Vector2(-10,0);
	}


}

