using UnityEngine;

public class Trains : MonoBehaviour
{
	public int maxPassengers;
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
		for (int i = currentPassengers; i <= maxPassengers; i++) {
			currentPassengers++;
			playerMove.boardTrain();
		}
		autoMovement.stopMove();
	}
}
