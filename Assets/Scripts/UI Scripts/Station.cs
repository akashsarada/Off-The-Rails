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
		transform.LeanScale(new Vector2(35f, 35f), 0.1f).setEaseOutCirc();
	}
	
	void OnMouseExit()
	{
		transform.LeanScale(new Vector2(25f, 25f), 0.1f).setEaseOutCirc();
	}
}
