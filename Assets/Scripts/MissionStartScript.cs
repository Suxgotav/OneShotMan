using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MissionStartScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
		Invoke("DestroyIt",1.0f);		
	}
	
	// Update is called once per frame
	void Update () {
		Time.timeScale = 0;		
	}

	void DestroyIt(){
		Destroy(this.gameObject);
	}
}
