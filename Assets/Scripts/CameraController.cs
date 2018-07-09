using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour {

	public GameObject player;

	public bool slide;
	public bool ySlide;


	// Use this for initialization
	void Start () {
		slide=false;
	}
	
	// Update is called once per frame
	void Update () {
		if(slide){
			Vector3 currentPosition = this.gameObject.transform.position = new Vector3(player.gameObject.transform.position.x,this.gameObject.transform.position.y,this.gameObject.transform.position.z);
		}

		if(ySlide){
			Vector3 currentPosition = this.gameObject.transform.position; //= new Vector3(player.gameObject.transform.position.x,this.gameObject.transform.position.y,this.gameObject.transform.position.z);
			Vector3 newPosition = Vector3.Lerp(currentPosition,currentPosition + new Vector3(0,1.0f,0),Mathf.SmoothStep(0.0f,1.2f,1));
			gameObject.transform.position = newPosition;
			ySlide=false;
		}

		if(Input.GetKey(KeyCode.E)){
			
		}
	}

	void CanSlide(){
		slide=true;
	}

	void CantSlide(){
		slide=false;
	}

	void CanYSlide(){
		ySlide=true;
	}

	void CantYSlide(){
		Vector3 currentPosition = this.gameObject.transform.position = new Vector3(this.gameObject.transform.position.x,player.gameObject.transform.position.y,this.gameObject.transform.position.z);
	}

	void OnTriggerEnter2D(Collider2D other){
		if(other.gameObject.tag.Equals("EnemyShot") || other.gameObject.tag.Equals("Shot"))
			Destroy(other.gameObject);
			GameObject.FindGameObjectWithTag("Player").SendMessage("CanShoot");
	}
}
