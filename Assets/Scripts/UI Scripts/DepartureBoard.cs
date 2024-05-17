using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DepartureBoard : MonoBehaviour
{
    public AudioSource source;
    public AudioClip open, close;

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
		// moves board up
		transform.LeanMoveLocal(new Vector2(-Screen.width / 2 + 175, -Screen.height / 2 + 200), 0.5f).setEaseOutCubic();
        // plays sound
		source.clip = open;
        source.Play();
	}
	
	void OnMouseExit()
	{
		// moves board down
		transform.LeanMoveLocal(new Vector2(-Screen.width / 2 + 175, -Screen.height / 2 - 150), 0.5f).setEaseOutCubic();
        // plays sound
		source.clip = close;
        source.Play();
	}
}
