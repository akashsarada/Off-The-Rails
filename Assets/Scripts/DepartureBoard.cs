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
		
		transform.position += Vector3.up * 6;
	}
	
	void OnMouseExit()
	{
		Debug.Log(":(");
		
		transform.position += Vector3.down * 6;
	}
}
