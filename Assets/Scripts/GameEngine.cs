using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameEngine : MonoBehaviour {
	public GameObject inimigo;
	

	// Use this for initialization
	void Start () {
	  InvokeRepeating("CriaInimigo",0.0f,2.0f);	
	}

	void Acabou () {
	 CancelInvoke("CriaInimigo");	
	}
	

	void CriaInimigo(){
		float alturaAleatoria = 4.0f * Random.value - 3;
		GameObject novoInimigo = Instantiate(inimigo);
		novoInimigo.transform.position = new Vector2(40.0f,alturaAleatoria);
		
	}
	// Update is called once per frame
	void Update () {
	}
}
