using UnityEngine;
using System.Collections;

public class Creation : MonoBehaviour
{
	public GameObject circlePrefab;
	public AutoMovement autoMovement;
	
	public bool creation = false;
	
	void Start() {
		autoMovement.targetX = -5;
	}
	
    void Update()
    {
		if (creation) {
			spawn();
		}
		
    }
	
	void spawn() {
		creation = false;
		int count = GameObject.FindGameObjectsWithTag("Circle").Length - 1;
		Debug.Log(GameObject.FindGameObjectsWithTag("Circle").Length);
		Instantiate(circlePrefab, new Vector2(6,-4), transform.rotation);
		Debug.Log(GameObject.FindGameObjectsWithTag("Circle").Length);
		GameObject.FindGameObjectsWithTag("Circle")[count + 1].GetComponent<AutoMovement>().targetX = GameObject.FindGameObjectsWithTag("Circle")[count].GetComponent<AutoMovement>().targetX + 1;;
	}
		
}