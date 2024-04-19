using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DepartureBoard : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
	
	void OnMouseEnter()
	{
		Debug.Log(":)");
		
		transform.LeanMoveLocal(new Vector2(175, 200), 1).setEaseOutCubic();
	}
	
	void OnMouseExit()
	{
		Debug.Log(":(");
		
		transform.LeanMoveLocal(new Vector2(175, -150), 1).setEaseOutCubic();
	}
}
