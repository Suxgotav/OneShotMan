using System.Collections;
using System.Collections.Generic;
using UnityEngine;




public class ShotScript : MonoBehaviour {
	
	public GameObject blast;
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

	void OnTriggerEnter2D(Collider2D other){
		if(other.tag.Equals("Enemy") || other.tag.Equals("EnemyShot")){
			GameObject newBlast = Instantiate(blast);
			newBlast.transform.position = this.transform.position;
			GameObject.FindWithTag("Player").SendMessage("CallCanShoot");
			Destroy(other.gameObject);
			Destroy(this.gameObject);
		}
		if(other.tag.Equals("Ground")){
			GameObject.FindWithTag("Player").SendMessage("CallCanShoot");
			Destroy(this.gameObject);
		}
	}
	
}
