using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class PlayerController : MonoBehaviour {

	Scene m_Scene;
	int charge;
	bool shoot;	
	public float speed = 3;
	
	public float jumpSpeed = 7f;

	public float fallMultiplier = 1.5f;
	public float lowJumpMultiplier = 1f;

	int leftRight;

	int pontos;

	bool isGrounded;

	public GameObject shot;

	public AudioClip shootAudio;
	public AudioClip jumpAudio;
	public AudioClip hurtAudio;

	public AudioSource sourceAudio;

	Rigidbody2D rb;

	Animator animator;

	public bool onLadder;

	public float climbSpeed;
	private float climbVelocity;	

	void Start(){
		sourceAudio = this.gameObject.GetComponent<AudioSource>();
		shoot=true;
		rb = GetComponent<Rigidbody2D>();
		isGrounded = false;	
		animator = GetComponent<Animator>();
		leftRight=0;
		charge=0;
		onLadder=false;
	}

	void FixedUpdate(){
		if(rb.velocity.y<0){
			rb.velocity += Vector2.up * Physics2D.gravity.y * (fallMultiplier - 1) * Time.deltaTime;
		} else if (rb.velocity.y > 0 && !Input.GetKey(KeyCode.Space)){
			rb.velocity += Vector2.up * Physics2D.gravity.y * (lowJumpMultiplier - 1) * Time.deltaTime;
		}
	
	}

	void Update(){
		
	}

	void LateUpdate(){

    	if (Input.GetKey(KeyCode.D)){
			animator.SetInteger("ShotUp",0);
			animator.SetInteger("Running",1);
			animator.SetInteger("ReverseRunning",0);
			leftRight=1;
        	transform.position += transform.right * speed * Time.deltaTime;
    	}
    	else if (Input.GetKey(KeyCode.A)){
			animator.SetInteger("ShotUp",0);
			animator.SetInteger("Running",0);
			animator.SetInteger("ReverseRunning",1);
        	transform.position -= transform.right * speed * Time.deltaTime;
			leftRight=2;
   	 	}
		else if(onLadder && Input.GetKey(KeyCode.W)){
			transform.position += transform.up * speed * 2 * Time.deltaTime;
		}
		else if(onLadder && Input.GetKey(KeyCode.S)){
			transform.position += transform.up * speed * -2 * Time.deltaTime;
		}	
		else{
			animator.SetInteger("Running",0);
			animator.SetInteger("ReverseRunning",0);	
		}
		if (isGrounded && Input.GetKeyDown(KeyCode.Space)){
			animator.SetInteger("Jump",1);
			animator.SetInteger("ShotUp",0);
			animator.SetInteger("ShotUpFoward",0);
			sourceAudio.PlayOneShot(jumpAudio);
        	GetComponent<Rigidbody2D>().velocity = Vector2.up * jumpSpeed;
			isGrounded=false;
    	}
		if(Input.GetKeyDown(KeyCode.RightArrow)){
				if(shoot){	
				animator.SetInteger("Running",1);	
				animator.SetInteger("ShotUp",0);
				animator.SetInteger("ShotUpFoward",0);
				animator.SetInteger("ReverseRunning",0);	
				shoot=false;
				GameObject newShot = Instantiate(shot);
				newShot.transform.position = transform.position + new Vector3(1.5f,0.1f);
				newShot.GetComponent<Rigidbody2D>().velocity = new Vector2(6,0);
				sourceAudio.PlayOneShot(shootAudio);
			}
		}
		/*if(Input.GetKeyDown(KeyCode.UpArrow)){
			    animator.SetInteger("ShotUpFoward",0);
				animator.SetInteger("ReverseRunning",0);
				animator.SetInteger("ShotUp",1);
				if(shoot){
				shoot=false;
				GameObject newShot = Instantiate(shot);
				newShot.transform.position = transform.position + new Vector3(0.0f,2.0f);
				newShot.GetComponent<Rigidbody2D>().velocity = new Vector2(0,12);
				sourceAudio.PlayOneShot(shootAudio);
				
			}
		}*/
		if(Input.GetKeyDown(KeyCode.LeftArrow)){
				if(shoot){
				animator.SetInteger("ReverseRunning",1);
				shoot=false;
				GameObject newShot = Instantiate(shot);
				newShot.transform.position = transform.position + new Vector3(-1.5f,0.1f);
				newShot.GetComponent<Rigidbody2D>().velocity = new Vector2(-8,0);
				sourceAudio.PlayOneShot(shootAudio);
				}
		}
		
	}
	void OnTriggerEnter2D(Collider2D other){
			if(other.tag.Equals("Enemy") || other.tag.Equals("Trap") || other.tag.Equals("EnemyShot")){
				//sourceAudio.PlayOneShot(hurtAudio);
				Invoke("ReloadLevel",0.0f);
				Destroy(this.gameObject);
			}
			if (other.tag.Equals("Ground") || other.tag.Equals("MovingPlataform")){
				animator.SetInteger("Jump",0);
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

	void OnLadder(){
		onLadder = true;
		//this.GetComponent<Rigidbody2D>().isKinematic = true;
		this.GetComponent<Rigidbody2D>().gravityScale = 0;
		this.GetComponent<Rigidbody2D>().velocity = new Vector2(0,0);
	}

	void OffLadder(){
		onLadder = false;
		this.GetComponent<Rigidbody2D>().gravityScale = 1;
		isGrounded=true;
	}

	void ReloadLevel(){
		m_Scene = SceneManager.GetActiveScene();
		string scenename = m_Scene.name;
		Application.LoadLevel(scenename);
	}

}
