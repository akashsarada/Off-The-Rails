using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AutoMovement : MonoBehaviour
{
	public PlayerMove playerMove;
	public float targetX;
	public float targetY;
	
    // Update is called once per frame
    void Update()
    {
		moveToPosition();
    }
	
	
	void moveToPosition() {
		if (Mathf.Abs(transform.position.y - targetY) < 0.05) {
			playerMove.vertical = 0;
		}			
		else if (transform.position.y < targetY) {
			playerMove.vertical = 1;
		}
		else if (transform.position.y > targetY) {
			playerMove.vertical = -1;
		}
		else {
			playerMove.vertical = 0;
		}
		
		if (Mathf.Abs(transform.position.x - targetX) < 0.05) {
			playerMove.horizontal = 0;
		}		
		else if (transform.position.x < targetX) {
			playerMove.horizontal = 1;
		}
		else if (transform.position.x > targetX) {
			playerMove.horizontal = -1;
		}
		else {
			playerMove.horizontal = 0;
		}
	}
	
	public void stopMove() {
		targetX = transform.position.x;
		targetY = transform.position.y;
	}
		
}
