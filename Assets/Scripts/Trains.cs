using UnityEngine;

public class Trains : MonoBehaviour
{
	public int maxPassengers;
	public int currentPassengers;
	private int loopcount = 0;
	private int count = 0;
	public bool board = false;
	public AutoMovement autoMovement;
	public PlayerMove playerMove;

	void Start() {
		Debug.Log(Application.targetFrameRate);
		Application.targetFrameRate = 45;
		Debug.Log(Application.targetFrameRate);
	}

    // Update is called once per frame
    void Update(){
		board = Input.GetKey("b");
        if (board && (loopcount < 1)) {
			board = false;
			loopcount++;
			boardTrain();
			
		}
		
		if (GameObject.FindGameObjectsWithTag("Circle")[0].GetComponent<AutoMovement>().finished() && (loopcount > 0)) {
			loopcount = 0;
		}
				
    }
	
	void boardTrain() {
		board = false;
		Debug.Log("Board");
		GameObject[] goa = GameObject.FindGameObjectsWithTag("Circle");
	
		for (int i = 0; i < (maxPassengers - currentPassengers); i++) {
			goa[i].GetComponent<AutoMovement>().targetX = -7;
			count++;
		}
		for (int i = count; i < goa.Length; i++) {
			goa[i].GetComponent<AutoMovement>().targetX -= count;
			//Debug.Log(i);
			//Debug.Log(count);
		}
		//while (!goa[count].GetComponent<AutoMovement>().finished()) {}
	}
	
}
