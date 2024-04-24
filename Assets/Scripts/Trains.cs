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
		playerMove.boardTrain();
		//for (int i = currentPassengers; i <= maxPassengers; i++) {
		//	Debug.Log("Boarding");
		//	currentPassengers++;
		//	playerMove.boardTrain();
		//}
		//autoMovement.stopMove();
	}
	
}
