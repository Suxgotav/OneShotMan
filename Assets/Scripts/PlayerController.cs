using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

	bool shoot;	
	float speed = 5;
	
	float jumpSpeed = 6;

	public float fallMultiplier = 2.5f;
	public float lowJumpMultiplier = 2f;

	int pontos;

	bool isGrounded;

	public GameObject shot;

	public AudioClip shootAudio;
	public AudioClip jumpAudio;
	public AudioClip hurtAudio;

	public AudioSource sourceAudio;

	Rigidbody2D rb;
	
	void Start(){
		sourceAudio = this.gameObject.GetComponent<AudioSource>();
		shoot=true;
		rb = GetComponent<Rigidbody2D>();
		isGrounded = false;	
	}

	void FixedUpdate(){
		if(rb.velocity.y<0){
			rb.velocity += Vector2.up * Physics2D.gravity.y * (fallMultiplier - 1) * Time.deltaTime;
		} else if (rb.velocity.y > 0 && !Input.GetKey(KeyCode.Space)){
			rb.velocity += Vector2.up * Physics2D.gravity.y * (lowJumpMultiplier - 1) * Time.deltaTime;
		}
	}


	void Update(){
    	if (Input.GetKey(KeyCode.D)){
        	transform.position += transform.right * speed * Time.deltaTime;
    	}
    	else if (Input.GetKey(KeyCode.A)){
        	transform.position -= transform.right * speed * Time.deltaTime;
   	 	}
		if (isGrounded && Input.GetKeyDown(KeyCode.Space)){
			sourceAudio.PlayOneShot(jumpAudio);
        	GetComponent<Rigidbody2D>().velocity = Vector2.up * jumpSpeed;
			isGrounded=false;
    	}
		if(Input.GetKeyDown(KeyCode.RightArrow)){
				if(shoot){
				shoot=false;
				GameObject newShot = Instantiate(shot);
				newShot.transform.position = transform.position + new Vector3(2.0f,0.3f);
				newShot.GetComponent<Rigidbody2D>().velocity = new Vector2(14,0);
				sourceAudio.PlayOneShot(shootAudio);
			}
		}
		if(Input.GetKeyDown(KeyCode.UpArrow)){
				if(shoot){
				shoot=false;
				GameObject newShot = Instantiate(shot);
				newShot.transform.position = transform.position + new Vector3(0.0f,2.0f);
				newShot.GetComponent<Rigidbody2D>().velocity = new Vector2(0,14);
				sourceAudio.PlayOneShot(shootAudio);
			}
		}
		if(Input.GetKeyDown(KeyCode.LeftArrow)){
				if(shoot){
				shoot=false;
				GameObject newShot = Instantiate(shot);
				newShot.transform.position = transform.position + new Vector3(-2.0f,0.3f);
				newShot.GetComponent<Rigidbody2D>().velocity = new Vector2(-14,0);
				sourceAudio.PlayOneShot(shootAudio);
			}
		}
	}
	void OnTriggerEnter2D(Collider2D other){
			if(other.tag.Equals("Enemy")){
				//sourceAudio.PlayOneShot(hurtAudio);
				Destroy(this.gameObject);
				Application.LoadLevel("Test");
			}if (other.tag.Equals("Ground")){
				isGrounded=true;
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
