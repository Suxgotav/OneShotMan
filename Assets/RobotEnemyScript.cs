using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RobotEnemyScript : MonoBehaviour {

	public GameObject enemyShot;
	public GameObject eShot;
	// Use this for initialization
	void Start () {
		InvokeRepeating("EnemyShoot",0.0f,4.0f);
		InvokeRepeating("CommonShot",0.4f,5.0f);

	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void EnemyShoot(){
		GameObject newShot = Instantiate(enemyShot);
		newShot.transform.position = transform.position - new Vector3(2.0f,0.0f);
	}


	void CommonShot(){
		GameObject Nshot = Instantiate(eShot);
		Nshot.transform.position = transform.position - new Vector3(2.0f,0.0f);
	}

	void OnTriggerEnter2D(Collider2D other){
		if(other.tag.Equals("Shot")){
			Destroy(this.gameObject);
		}
	}
}
