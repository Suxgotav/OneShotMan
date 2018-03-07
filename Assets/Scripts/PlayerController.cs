using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

	bool shoot;	
	float speed = 5;
	
	float jumpSpeed = 10;
	int pontos;
	public GameObject shot;


	void Start(){
		shoot=true;	
	}

	void Update(){
    	if (Input.GetKey(KeyCode.D)){
        	transform.position += transform.right * speed * Time.deltaTime;
    	}
    	else if (Input.GetKey(KeyCode.A)){
        	transform.position -= transform.right * speed * Time.deltaTime;
   	 	}
		if (Input.GetKey(KeyCode.Space)){
        	transform.position += transform.up * jumpSpeed * Time.deltaTime;
    	}
		if(Input.GetKeyDown(KeyCode.RightArrow)){
				if(shoot){
				shoot=false;
				GameObject newShot = Instantiate(shot);
				newShot.transform.position = transform.position + new Vector3(2.0f,0.3f);
			}
		}
		if(Input.GetKeyDown(KeyCode.UpArrow)){
				if(shoot){
				shoot=false;
				GameObject newShot = Instantiate(shot);
				newShot.transform.position = transform.position + new Vector3(0.0f,2.0f);
			}
		}
		if(Input.GetKeyDown(KeyCode.LeftArrow)){
				if(shoot){
				shoot=false;
				GameObject newShot = Instantiate(shot);
				newShot.transform.position = transform.position + new Vector3(-2.0f,0.3f);
			}
		}
	}
	void OnTriggerEnter2D(Collider2D other){
			if(other.tag.Equals("Enemy")){
				Destroy(this.gameObject);
				Application.LoadLevel("Test");
			}
			
	}


	void MarcaPonto(){
		pontos++;
	}

	void CanShoot(){
		shoot=true;
	}

	void CallCanShoot(){
		Invoke("CanShoot",0.0f);
	}

}
