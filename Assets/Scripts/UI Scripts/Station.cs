using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Station : MonoBehaviour
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
		transform.LeanScale(Vector2(1.25, 1.25), 0.5f);
	}
	
	void OnMouseExit()
	{
		transform.LeanScale(Vector2(1, 1), 0.5f);
	}
}
