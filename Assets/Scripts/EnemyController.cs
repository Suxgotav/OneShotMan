using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour {

	public AudioClip deadSound;

	AudioSource sourceOfAudio;

	void Start () {
		sourceOfAudio = GetComponent<AudioSource>();
		GetComponent<Rigidbody2D>().velocity = new Vector2(-4,0);
	}
	
	// Update is called once per frame
	void Update () {
		if(transform.position.x < -15){
			Destroy(this.gameObject);
		}
	}

	void OnTriggerEnter2D(Collider2D other){
		if(other.tag.Equals("Shot")){
			//sourceOfAudio.PlayOneShot(deadSound);
			Destroy(this.gameObject);
		}
	}
}
