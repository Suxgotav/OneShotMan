using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SinMovementEnemy : MonoBehaviour {

	// Use this for initialization
	public float horizontalSpeed;
	public float verticalSpeed;
	public float amplitude;

	public Vector3 temPosition;

	public Vector3 startPosition;
	
	void Start () {
		temPosition = transform.position;
		startPosition = transform.position;
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		temPosition.x += horizontalSpeed;
		temPosition.y = Mathf.Sin(Time.realtimeSinceStartup * verticalSpeed) * amplitude + startPosition.y;
		transform.position = temPosition;
	}

	void OnTriggerEnter2D(Collider2D other){
		if(other.tag.Equals("Shot")){
			Destroy(this.gameObject);
		}
	}
	
}
