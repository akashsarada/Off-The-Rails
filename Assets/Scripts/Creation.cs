using UnityEngine;
using System.Collections;

public class Creation : MonoBehaviour
{
	public GameObject circlePrefab;
	public AutoMovement autoMovement;
	
	public bool creation = false;
	
    void Update()
    {
		if (creation) {
			spawn();
		}
		
    }
	
	void spawn() {
		creation = false;
		int count = GameObject.FindGameObjectsWithTag("Circle").Length - 1;
		
		autoMovement.targetX = autoMovement.targetX + count;
		Instantiate(circlePrefab, new Vector2(6,-4), transform.rotation);
		autoMovement.targetX = autoMovement.targetX - count;
	}
}