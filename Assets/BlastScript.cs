using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlastScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
		Invoke("DestroyThis",0.5f);
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void DestroyThis(){
		Destroy(this.gameObject);
	}
}
