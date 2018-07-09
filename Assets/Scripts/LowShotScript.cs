using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LowShotScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
		this.GetComponent<Rigidbody2D>().velocity = new Vector3(-8,0);
		Invoke("DestroyMe",1.0f);
	}
	
	// Update is called once per frame
	void Update () {
		if(this.gameObject.transform.position.x<=GameObject.FindGameObjectWithTag("Player").transform.position.x - 5){
			Destroy(this.gameObject);
		}
	}

	void OnTriggerEnter2D(Collider2D other){
		if(other.tag.Equals("Enemy"))
		Destroy(this.gameObject);
	}

	void DestroyMe(){
		Destroy(this.gameObject);
	}
	
}
