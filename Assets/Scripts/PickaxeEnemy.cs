using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickaxeEnemy : MonoBehaviour {

	public GameObject pickaxe;

	public GameObject player;

	public bool PickaxeNotExists;

	// Use this for initialization
	void Start () {
		PickaxeNotExists = true;
	}
	
	// Update is called once per frame
	void LateUpdate () {
			if (player.transform.position.x >= transform.position.x -10 && player.transform.position.x < transform.position.x){
				Invoke("AttackLeft",0.0f);
			}
			else if (player.transform.position.x >= transform.position.x && player.transform.position.x < transform.position.x + 10){
				Invoke("AttackRight",0.0f);
			}
	}

	void AttackRight(){
			if(PickaxeNotExists){
				PickaxeNotExists=false;
				GameObject newPickaxe = Instantiate(pickaxe);
				newPickaxe.transform.position = transform.position;
				newPickaxe.GetComponent<Rigidbody2D>().AddForce(new Vector2(2,2),ForceMode2D.Impulse);
			}
	}
	void AttackLeft() {
		if(PickaxeNotExists){
			PickaxeNotExists = false;
			GameObject newPickaxe = Instantiate(pickaxe);
			newPickaxe.transform.position = transform.position;
			newPickaxe.GetComponent<Rigidbody2D>().AddForce(new Vector2(-2,2),ForceMode2D.Impulse);
		}
	}

	void PickAxeOK(){
		PickaxeNotExists = true;
	}
	
}
