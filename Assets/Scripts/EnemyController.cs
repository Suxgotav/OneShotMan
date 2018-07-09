using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour {

	public AudioClip deadSound;

	AudioSource sourceOfAudio;

	bool run;
	void Start () {
		sourceOfAudio = GetComponent<AudioSource>();
		run=false;
	}
	
	// Update is called once per frame
	void Update () {
		
		RaycastHit2D groundInfo = Physics2D.Raycast(transform.position,Vector2.left,10f);
		
		if(groundInfo.collider.CompareTag("Player"))
		GetComponent<Rigidbody2D>().velocity = new Vector2(-14,0);


		
		if(GameObject.FindGameObjectWithTag("Player").transform.position.x < -15){
			Destroy(this.gameObject);
		}
	}

	void PlaySound(){
		sourceOfAudio.Play();
	}

	void OnTriggerEnter2D(Collider2D other){
		if(other.tag.Equals("Shot")){
			sourceOfAudio.PlayOneShot(deadSound);
			Destroy(this.gameObject);
		}
	}
}
