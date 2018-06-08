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
			this.gameObject.transform.position = new Vector3(player.gameObject.transform.position.x,this.gameObject.transform.position.y,this.gameObject.transform.position.z);
		}

		if(ySlide){
			this.gameObject.transform.position = new Vector3(this.gameObject.transform.position.x,player.gameObject.transform.position.y,this.gameObject.transform.position.z);
		}
	}

	void CanSlide(){
		slide=true;
	}

	void CantSlide(){
		ySlide=false;
	}

	void CanYSlide(){
		ySlide=true;
	}

	void CantYSlider(){
		slide=false;
	}

}
