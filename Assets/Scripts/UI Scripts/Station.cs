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
		transform.LeanScale(new Vector2(1.25f, 1.25f), 0.5f);
	}
	
	void OnMouseExit()
	{
		transform.LeanScale(new Vector2(1f, 1f), 0.5f);
	}
}
