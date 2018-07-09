using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GolemEnemyControl : MonoBehaviour {

	Animator animator;
	bool run;

	public AudioClip punchAudio;

	public GameObject item;

	public AudioSource sourceAudio;
	// Use this for initialization
	void Start () {
		animator = GetComponent<Animator>();
		run=false;
		sourceAudio = this.gameObject.GetComponent<AudioSource>();
		InvokeRepeating("PlaySound",1.0f,1.0f);
		
	}
	
	// Update is called once per frame
	void Update () {
		RaycastHit2D groundInfo = Physics2D.Raycast(transform.position,Vector2.left,15.0f);
		Debug.DrawRay(transform.position,Vector2.left,Color.blue,5.0f);
		if(groundInfo.collider)
		animator.SetInteger("PlayerNearby",1);

	}

	void PlaySound(){
		sourceAudio.PlayOneShot(punchAudio);
	}

	void OnTriggerEnter2D(Collider2D other){
		if(other.tag.Equals("Shot")){
			Destroy(this.gameObject);
		}
		if(other.tag.Equals("Player")){
			animator.SetInteger("PlayerNearby",1);
		}
	}

	void OnCollisionEnter2D(Collider2D other){
		if(other.tag.Equals("Shot")){
			Destroy(this.gameObject);
		}
	}
}
