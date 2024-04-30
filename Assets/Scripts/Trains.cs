using UnityEngine;

public class Trains : MonoBehaviour
{
	public int maxPassengers = 5;
	public int currentPassengers;
	public bool board = false;
	public AutoMovement autoMovement;
	public PlayerMove playerMove;

    // Update is called once per frame
    void Update(){
		board = Input.GetKey("b");
        if (board) {
			boardTrain();
		}
				
    }
	
	void boardTrain() {
		Debug.Log("Board");
		board = false;
		GameObject[] goa = GameObject.FindGameObjectsWithTag("Circle");
		int count = 0;
		for (int i = 0; i < (maxPassengers - currentPassengers); i++) {
			goa[i].GetComponent<AutoMovement>().targetX = -7;
			count++;
		}
		while (!goa[count].GetComponent<AutoMovement>().finished()) {}
		Debug.Log(goa.Length);
		Debug.Log(count);
	}
	
}
