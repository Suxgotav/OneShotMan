using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RobotEnemyScript : MonoBehaviour {

	public GameObject enemyShot;
	public GameObject eShot;
	// Use this for initialization
	
	public float attackNumber;
	void Start () {
		InvokeRepeating("EnemyShoot",0.0f,2.0f);
		attackNumber = Random.Range(0,1);
	}
	
	// Update is called once per frame
	void Update () {
		Debug.Log(attackNumber);
	}

	void EnemyShoot(){
		if(attackNumber>=0.5f){
			GameObject newShot = Instantiate(enemyShot);
			newShot.transform.position = transform.position - new Vector3(2.0f,0.0f);
			attackNumber = Random.Range(0,2);
		}
		else if (attackNumber<=0.5f){
			GameObject Nshot = Instantiate(eShot);
			Nshot.transform.position = transform.position - new Vector3(2.0f,0.0f);
			attackNumber = Random.Range(0,2);
		}
	}



	void OnTriggerEnter2D(Collider2D other){
		if(other.tag.Equals("Shot")){
			Destroy(this.gameObject);
		}
	}
}
