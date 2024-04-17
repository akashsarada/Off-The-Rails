using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour {
	public Rigidbody2D body;
	public AutoMovement autoMovement;

	public float horizontal;
	public float vertical;
	public float runSpeed = 3.0f;

    // Update is called once per frame
    void Update() {		
	
	}

	void FixedUpdate() {  
   		body.velocity = new Vector2(horizontal * runSpeed, vertical * runSpeed);
	}
	
	private void OnCollisionEnter2D(Collision2D col) {
		if (col.gameObject.CompareTag("Trains")) {
			Destroy(gameObject);
		}
	}
	
	public void boardTrain() {
		Debug.Log("Boarding");
		autoMovement.targetX = -7;
	}
	
}